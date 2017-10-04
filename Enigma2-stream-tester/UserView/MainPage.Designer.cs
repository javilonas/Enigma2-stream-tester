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
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Log_listBox);
            this.Controls.Add(this.StartButton);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(686, 215);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox Log_listBox;
        public System.Windows.Forms.Button StartButton;
    }
}
