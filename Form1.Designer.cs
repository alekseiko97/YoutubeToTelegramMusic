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
            this.code_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.authenticate_btn = new System.Windows.Forms.Button();
            this.connect_btn = new System.Windows.Forms.Button();
            this.send_btn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // code_tb
            // 
            this.code_tb.Location = new System.Drawing.Point(18, 185);
            this.code_tb.Name = "code_tb";
            this.code_tb.Size = new System.Drawing.Size(224, 29);
            this.code_tb.TabIndex = 0;
            this.code_tb.Text = "Code from Telegram";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter code from Telegram:";
            // 
            // authenticate_btn
            // 
            this.authenticate_btn.Location = new System.Drawing.Point(272, 185);
            this.authenticate_btn.Name = "authenticate_btn";
            this.authenticate_btn.Size = new System.Drawing.Size(156, 38);
            this.authenticate_btn.TabIndex = 2;
            this.authenticate_btn.Text = "Connect";
            this.authenticate_btn.UseVisualStyleBackColor = true;
            this.authenticate_btn.Click += new System.EventHandler(this.authenticate_btn_Click);
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(18, 38);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(275, 70);
            this.connect_btn.TabIndex = 4;
            this.connect_btn.Text = "Send authorization code";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(18, 261);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(138, 42);
            this.send_btn.TabIndex = 6;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 352);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(612, 29);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "YouTube link";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(827, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Location = new System.Drawing.Point(509, 38);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(203, 70);
            this.disconnect_btn.TabIndex = 10;
            this.disconnect_btn.Text = "Disconnect";
            this.disconnect_btn.UseVisualStyleBackColor = true;
            this.disconnect_btn.Click += new System.EventHandler(this.disconnect_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 502);
            this.Controls.Add(this.disconnect_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.authenticate_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.code_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox code_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button authenticate_btn;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button disconnect_btn;
    }
}

