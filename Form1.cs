using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeleSharp.TL;
using TeleSharp.TL.Messages;
using TLSharp;
using TLSharp.Core;
using TLSharp.Core.Utils;

namespace YoutubeToTelegramMusic
{
    public partial class Form1 : Form
    {
        private readonly int API_ID = 2148225;
        private readonly string API_HASH = "628a22504e0f925d2d5bd97c62f3863f";
        private readonly string userNumber = "+37255510396";
        private TelegramClient client;
        private string hash;
        private TLUser user;

        public Form1()
        {
            InitializeComponent();
        }


        private void connect_btn_Click(object sender, EventArgs e)
        {
            EstablishTelegramConnection();
        }

        private void authenticate_btn_Click(object sender, EventArgs e)
        {
            AuthorizeUser();
        }

        private async void EstablishTelegramConnection()
        {
            try
            {
                this.client = new TelegramClient(API_ID, API_HASH);
                await client.ConnectAsync();

                System.Threading.Thread.Sleep(1000);

                this.hash = await client.SendCodeRequestAsync(userNumber);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private async void AuthorizeUser()
        {
            string code = code_tb.Text;

            if (!(string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(hash) || code == "Code from Telegram"))
            {
                //if (!client.IsUserAuthorized())
                //{
                    this.user = await client.MakeAuthAsync(userNumber, hash, code);
                    MessageBox.Show(user.Status.ToString());
                //}
            }
            else MessageBox.Show("Please check your input!");
        }

        private async void SendMusicToChannel()
        {
            if (user == null) return;

            var dialogs = (TLDialogs)await client.GetUserDialogsAsync();

            // find chat by title
            TLChannel chat = dialogs.Chats.Where(c => c.GetType() == typeof(TLChannel)).Cast<TLChannel>().FirstOrDefault(c => c.Title == "Music");

            string filePath = "test.mp3";
            var fileResult = await client.UploadFile(filePath, new System.IO.StreamReader(filePath));

            // create an attribute for a file
            TLDocumentAttributeFilename s = new TLDocumentAttributeFilename
            {
                FileName = filePath.Replace(".mp3", "")
            };
            TLVector<TLAbsDocumentAttribute> attributes = new TLVector<TLAbsDocumentAttribute>();
            attributes.Add(s);

            // finally, send the file to the channel
            await client.SendUploadedDocument(
                new TLInputPeerChannel() { ChannelId = chat.Id, AccessHash = (long)chat.AccessHash },
                fileResult,
                "",
                 "audio/mpeg",
                 attributes);
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            SendMusicToChannel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            client.Dispose();
        }
    }
}
