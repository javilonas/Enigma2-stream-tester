namespace Enigma2_stream_tester.UserView
{
    partial class MainPage
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
            this.Log_listBox = new System.Windows.Forms.ListBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Working_label = new System.Windows.Forms.Label();
            this.Best = new System.Windows.Forms.Label();
            this.Best_label = new System.Windows.Forms.Label();
            this.notWorking_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.noChannel_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Log_listBox
            // 
            this.Log_listBox.FormattingEnabled = true;
            this.Log_listBox.Location = new System.Drawing.Point(3, 0);
            this.Log_listBox.Name = "Log_listBox";
            this.Log_listBox.Size = new System.Drawing.Size(680, 160);
            this.Log_listBox.TabIndex = 9;
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(175, 166);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(320, 43);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start tester";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(5, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Working streams:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(501, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Not working streams:";
            // 
            // Working_label
            // 
            this.Working_label.AutoSize = true;
            this.Working_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Working_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Working_label.Location = new System.Drawing.Point(50, 188);
            this.Working_label.Name = "Working_label";
            this.Working_label.Size = new System.Drawing.Size(14, 13);
            this.Working_label.TabIndex = 12;
            this.Working_label.Text = "0";
            // 
            // Best
            // 
            this.Best.AutoSize = true;
            this.Best.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Best.ForeColor = System.Drawing.Color.Blue;
            this.Best.Location = new System.Drawing.Point(123, 166);
            this.Best.Name = "Best";
            this.Best.Size = new System.Drawing.Size(36, 13);
            this.Best.TabIndex = 13;
            this.Best.Text = "Best:";
            // 
            // Best_label
            // 
            this.Best_label.AutoSize = true;
            this.Best_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Best_label.ForeColor = System.Drawing.Color.Blue;
            this.Best_label.Location = new System.Drawing.Point(132, 188);
            this.Best_label.Name = "Best_label";
            this.Best_label.Size = new System.Drawing.Size(14, 13);
            this.Best_label.TabIndex = 14;
            this.Best_label.Text = "0";
            // 
            // notWorking_label
            // 
            this.notWorking_label.AutoSize = true;
            this.notWorking_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.notWorking_label.ForeColor = System.Drawing.Color.Red;
            this.notWorking_label.Location = new System.Drawing.Point(630, 171);
            this.notWorking_label.Name = "notWorking_label";
            this.notWorking_label.Size = new System.Drawing.Size(14, 13);
            this.notWorking_label.TabIndex = 15;
            this.notWorking_label.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(501, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "No channel:";
            // 
            // noChannel_label
            // 
            this.noChannel_label.AutoSize = true;
            this.noChannel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noChannel_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.noChannel_label.Location = new System.Drawing.Point(630, 188);
            this.noChannel_label.Name = "noChannel_label";
            this.noChannel_label.Size = new System.Drawing.Size(14, 13);
            this.noChannel_label.TabIndex = 17;
            this.noChannel_label.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Enigma2_stream_tester.Properties.Resources.arrow_right;
            this.pictureBox1.Location = new System.Drawing.Point(80, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.noChannel_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.notWorking_label);
            this.Controls.Add(this.Best_label);
            this.Controls.Add(this.Best);
            this.Controls.Add(this.Working_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Log_listBox);
            this.Controls.Add(this.StartButton);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(686, 215);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox Log_listBox;
        public System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Best;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label Working_label;
        public System.Windows.Forms.Label Best_label;
        public System.Windows.Forms.Label notWorking_label;
        public System.Windows.Forms.Label noChannel_label;
    }
}
