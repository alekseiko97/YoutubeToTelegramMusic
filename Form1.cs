using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using TeleSharp.TL;
using TeleSharp.TL.Messages;
using TLSharp.Core;
using TLSharp.Core.Utils;
using VideoLibrary;

namespace YoutubeToTelegramMusic
{
    public partial class Form1 : Form
    {
        /* variables*/
        private readonly int API_ID = 2148225;
        private readonly string API_HASH = "628a22504e0f925d2d5bd97c62f3863f";
        private readonly string userNumber = "+37255510396";
        private TelegramClient client;
        private string hash;
        private TLUser user;

        /* form constructor*/
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        /* GUI control actions*/
        private void connect_btn_Click(object sender, EventArgs e)
        {
            EstablishTelegramConnection();
        }
        private void authenticate_btn_Click(object sender, EventArgs e)
        {
            AuthorizeUser();
        }
        private void send_btn_Click(object sender, EventArgs e)
        {
            SendMusicToChannel();
        }
        private void download_btn_Click(object sender, EventArgs e)
        {
            DownloadFromYoutube();
        }

        /* Downloads video from YouTube and converts it to .mp3 file 
           @return local path to converted .mp3 file */
        private string DownloadFromYoutube()
        {
            /* TODO: Check for youtube link field */
            if (string.IsNullOrWhiteSpace(youtube_tb.Text))
            {
                MessageBox.Show("Please enter a valid YouTube link");
                return "";
            }

            var youtube = YouTube.Default;
            var vid = youtube.GetVideo(youtube_tb.Text);
            File.WriteAllBytes(vid.FullName, vid.GetBytes());

            var inputFile = new MediaFile { Filename = vid.FullName };
            var outputFile = new MediaFile { Filename = vid.FullName.Replace(".mp4", ".mp3") };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                engine.Convert(inputFile, outputFile);

                if (InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        engine.ConvertProgressEvent += (sender, args) => progressBar1.Value = Convert.ToInt32(args.ProcessedDuration.TotalMinutes / args.TotalDuration.TotalMinutes * 100 * 0.85);
                    });
                }


                // show download progress in the progress bar
            }

            // Register the progress events. We treat the download progress as 85% of the progress and the extraction progress only as 15% of the progress,
            // because the download will take much longer than the audio extraction.
            //audioDownloader.DownloadProgressChanged += (sender, args) => progressBar1.Value = Convert.ToInt32(args.ProgressPercentage * 0.85);
            //audioDownloader.AudioExtractionProgressChanged += (sender, args) => progressBar1.Value = Convert.ToInt32(args.ProgressPercentage * 0.15);

            return outputFile.Filename;
        }

        /* Send authorization code request to Telegram */
        private async void EstablishTelegramConnection()
        {
            try
            {
                this.client = new TelegramClient(API_ID, API_HASH);
                await client.ConnectAsync();

                this.hash = await client.SendCodeRequestAsync(userNumber);

                // enable controls to enter received code 
                code_tb.Enabled = true;
                authenticate_btn.Enabled = true;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        /* Authorize the user with the received code */
        private async void AuthorizeUser()
        {
            string code = code_tb.Text;

            if (!(string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(hash) || code == "Code from Telegram"))
            {
                try
                {
                    this.user = await client.MakeAuthAsync(userNumber, hash, code);
                    MessageBox.Show(user.Status.ToString());

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Please check your input!");
        }

        /* This function accepts downloaded music from YouTube and sends it to Telegram channel */
        private async void SendMusicToChannel()
        {
            if (user == null)
            {
                MessageBox.Show("Telegram user is not authorized");
                return;
            }

            var dialogs = (TLDialogs)await client.GetUserDialogsAsync();

            // find Telegram channel by name
            TLChannel chat = dialogs.Chats.Where(c => c.GetType() == typeof(TLChannel)).Cast<TLChannel>().FirstOrDefault(c => c.Title == "Music");

            string filePath = this.DownloadFromYoutube();

            if (string.IsNullOrEmpty(filePath)) return;

            // upload file
            var fileResult = await client.UploadFile(filePath, new StreamReader(filePath));

            // create an attribute for a file
            TLDocumentAttributeFilename s = new TLDocumentAttributeFilename
            {
                FileName = filePath.Replace(".mp3", "")
            };
            TLVector<TLAbsDocumentAttribute> attributes = new TLVector<TLAbsDocumentAttribute>
            {
                s
            };

            // finally, send the file to the channel
            client.SendUploadedDocument(
                new TLInputPeerChannel() { ChannelId = chat.Id, AccessHash = (long)chat.AccessHash },
                fileResult,
                "",
                 "audio/mpeg",
                 attributes);

        }

        /* Clean up code field when it is in focus*/
        private void code_tb_Enter(object sender, EventArgs e)
        {
            code_tb.Text = "";
        }
    }
}
