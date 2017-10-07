namespace Enigma2_stream_tester.UserView
{
    partial class FtpPage
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ftpLogin_Button = new System.Windows.Forms.Button();
            this.ftpLogin_Textbox = new System.Windows.Forms.TextBox();
            this.ftpPassword_Textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ftpDirectory_comboBox = new System.Windows.Forms.ComboBox();
            this.ftp_checkBox = new System.Windows.Forms.CheckBox();
            this.ftpLink_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ftpLogin_Button
            // 
            this.ftpLogin_Button.Enabled = false;
            this.ftpLogin_Button.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftpLogin_Button.Location = new System.Drawing.Point(484, 154);
            this.ftpLogin_Button.Name = "ftpLogin_Button";
            this.ftpLogin_Button.Size = new System.Drawing.Size(179, 49);
            this.ftpLogin_Button.TabIndex = 5;
            this.ftpLogin_Button.Text = "Login";
            this.ftpLogin_Button.UseVisualStyleBackColor = true;
            this.ftpLogin_Button.Click += new System.EventHandler(this.FtpLogin_Button_Click);
            // 
            // ftpLogin_Textbox
            // 
            this.ftpLogin_Textbox.Enabled = false;
            this.ftpLogin_Textbox.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftpLogin_Textbox.Location = new System.Drawing.Point(32, 120);
            this.ftpLogin_Textbox.Name = "ftpLogin_Textbox";
            this.ftpLogin_Textbox.Size = new System.Drawing.Size(221, 28);
            this.ftpLogin_Textbox.TabIndex = 2;
            // 
            // ftpPassword_Textbox
            // 
            this.ftpPassword_Textbox.Enabled = false;
            this.ftpPassword_Textbox.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftpPassword_Textbox.Location = new System.Drawing.Point(32, 175);
            this.ftpPassword_Textbox.Name = "ftpPassword_Textbox";
            this.ftpPassword_Textbox.PasswordChar = '*';
            this.ftpPassword_Textbox.Size = new System.Drawing.Size(221, 28);
            this.ftpPassword_Textbox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ftpDirectory_comboBox);
            this.groupBox1.Controls.Add(this.ftp_checkBox);
            this.groupBox1.Controls.Add(this.ftpLogin_Button);
            this.groupBox1.Controls.Add(this.ftpLink_Textbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ftpLogin_Textbox);
            this.groupBox1.Controls.Add(this.ftpPassword_Textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 209);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send files direct to FTP";
            // 
            // ftpDirectory_comboBox
            // 
            this.ftpDirectory_comboBox.Enabled = false;
            this.ftpDirectory_comboBox.FormattingEnabled = true;
            this.ftpDirectory_comboBox.Location = new System.Drawing.Point(298, 122);
            this.ftpDirectory_comboBox.Name = "ftpDirectory_comboBox";
            this.ftpDirectory_comboBox.Size = new System.Drawing.Size(143, 29);
            this.ftpDirectory_comboBox.TabIndex = 7;
            this.ftpDirectory_comboBox.SelectedIndexChanged += new System.EventHandler(this.FtpDirectory_comboBox_SelectedIndexChanged);
            // 
            // ftp_checkBox
            // 
            this.ftp_checkBox.AutoSize = true;
            this.ftp_checkBox.Location = new System.Drawing.Point(539, 27);
            this.ftp_checkBox.Name = "ftp_checkBox";
            this.ftp_checkBox.Size = new System.Drawing.Size(124, 25);
            this.ftp_checkBox.TabIndex = 6;
            this.ftp_checkBox.Text = "Send to ftp";
            this.ftp_checkBox.UseVisualStyleBackColor = true;
            this.ftp_checkBox.CheckedChanged += new System.EventHandler(this.Ftp_CheckedChanged);
            // 
            // ftpLink_Textbox
            // 
            this.ftpLink_Textbox.Enabled = false;
            this.ftpLink_Textbox.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftpLink_Textbox.Location = new System.Drawing.Point(32, 61);
            this.ftpLink_Textbox.Name = "ftpLink_Textbox";
            this.ftpLink_Textbox.Size = new System.Drawing.Size(409, 28);
            this.ftpLink_Textbox.TabIndex = 1;
            this.ftpLink_Textbox.Text = "ftp://";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "FTP url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Send to directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // FtpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FtpPage";
            this.Size = new System.Drawing.Size(686, 215);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ftpLogin_Button;
        private System.Windows.Forms.TextBox ftpLogin_Textbox;
        private System.Windows.Forms.TextBox ftpPassword_Textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ftpLink_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ftpDirectory_comboBox;
        public System.Windows.Forms.CheckBox ftp_checkBox;
    }
}
