namespace YoutubeToTelegramMusic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.youtube_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.authenticate_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.code_tb = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.connect_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.download_btn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // youtube_tb
            // 
            this.youtube_tb.Location = new System.Drawing.Point(114, 38);
            this.youtube_tb.Margin = new System.Windows.Forms.Padding(2);
            this.youtube_tb.Name = "youtube_tb";
            this.youtube_tb.Size = new System.Drawing.Size(501, 26);
            this.youtube_tb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "YouTube link";
            // 
            // authenticate_btn
            // 
            this.authenticate_btn.Enabled = false;
            this.authenticate_btn.Location = new System.Drawing.Point(9, 202);
            this.authenticate_btn.Margin = new System.Windows.Forms.Padding(2);
            this.authenticate_btn.Name = "authenticate_btn";
            this.authenticate_btn.Size = new System.Drawing.Size(183, 32);
            this.authenticate_btn.TabIndex = 2;
            this.authenticate_btn.Text = "Connect";
            this.authenticate_btn.UseVisualStyleBackColor = true;
            this.authenticate_btn.Click += new System.EventHandler(this.authenticate_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter code from Telegram:";
            // 
            // code_tb
            // 
            this.code_tb.Enabled = false;
            this.code_tb.Location = new System.Drawing.Point(9, 162);
            this.code_tb.Margin = new System.Windows.Forms.Padding(2);
            this.code_tb.Name = "code_tb";
            this.code_tb.Size = new System.Drawing.Size(184, 26);
            this.code_tb.TabIndex = 0;
            this.code_tb.Text = "Code from Telegram";
            this.code_tb.Enter += new System.EventHandler(this.code_tb_Enter);
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(9, 90);
            this.send_btn.Margin = new System.Windows.Forms.Padding(2);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(113, 35);
            this.send_btn.TabIndex = 6;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(9, 33);
            this.connect_btn.Margin = new System.Windows.Forms.Padding(2);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(221, 58);
            this.connect_btn.TabIndex = 4;
            this.connect_btn.Text = "Send authorization code";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connect_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.authenticate_btn);
            this.groupBox1.Controls.Add(this.code_tb);
            this.groupBox1.Location = new System.Drawing.Point(15, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(254, 342);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telegram";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.download_btn);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.youtube_tb);
            this.groupBox2.Controls.Add(this.send_btn);
            this.groupBox2.Location = new System.Drawing.Point(286, 33);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(646, 157);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YouTube";
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(186, 90);
            this.download_btn.Margin = new System.Windows.Forms.Padding(2);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(113, 35);
            this.download_btn.TabIndex = 14;
            this.download_btn.Text = "Download";
            this.download_btn.UseVisualStyleBackColor = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(315, 90);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(299, 32);
            this.progressBar1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox youtube_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button authenticate_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox code_tb;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button download_btn;
    }
}

