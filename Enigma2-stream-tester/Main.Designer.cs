namespace Enigma2_stream_tester
{
    partial class Main
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScanProgressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mysql_enable_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressValue_Label = new System.Windows.Forms.Label();
            this.pagePanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScanProgressBar
            // 
            this.ScanProgressBar.Location = new System.Drawing.Point(-1, 240);
            this.ScanProgressBar.Name = "ScanProgressBar";
            this.ScanProgressBar.Size = new System.Drawing.Size(688, 23);
            this.ScanProgressBar.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFilesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFilesToolStripMenuItem
            // 
            this.loadFilesToolStripMenuItem.Name = "loadFilesToolStripMenuItem";
            this.loadFilesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.loadFilesToolStripMenuItem.Text = "Load files";
            this.loadFilesToolStripMenuItem.Click += new System.EventHandler(this.LoadFilesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testerToolStripMenuItem,
            this.mainSettingsToolStripMenuItem,
            this.fTPSettingsToolStripMenuItem,
            this.mySQLToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // testerToolStripMenuItem
            // 
            this.testerToolStripMenuItem.Name = "testerToolStripMenuItem";
            this.testerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testerToolStripMenuItem.Text = "Tester";
            this.testerToolStripMenuItem.Click += new System.EventHandler(this.TesterToolStripMenuItem_Click);
            // 
            // mainSettingsToolStripMenuItem
            // 
            this.mainSettingsToolStripMenuItem.Name = "mainSettingsToolStripMenuItem";
            this.mainSettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mainSettingsToolStripMenuItem.Text = "Main settings";
            this.mainSettingsToolStripMenuItem.Click += new System.EventHandler(this.MainToolStripMenuItem_Click);
            // 
            // fTPSettingsToolStripMenuItem
            // 
            this.fTPSettingsToolStripMenuItem.Name = "fTPSettingsToolStripMenuItem";
            this.fTPSettingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fTPSettingsToolStripMenuItem.Text = "FTP settings";
            this.fTPSettingsToolStripMenuItem.Click += new System.EventHandler(this.FtpToolStripMenuItem_Click);
            // 
            // mySQLToolStripMenuItem
            // 
            this.mySQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectSettingsToolStripMenuItem,
            this.mysql_enable_MenuItem});
            this.mySQLToolStripMenuItem.Name = "mySQLToolStripMenuItem";
            this.mySQLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mySQLToolStripMenuItem.Text = "MySQL";
            // 
            // connectSettingsToolStripMenuItem
            // 
            this.connectSettingsToolStripMenuItem.Name = "connectSettingsToolStripMenuItem";
            this.connectSettingsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.connectSettingsToolStripMenuItem.Text = "Connect settings";
            // 
            // mysql_enable_MenuItem
            // 
            this.mysql_enable_MenuItem.Checked = true;
            this.mysql_enable_MenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mysql_enable_MenuItem.Name = "mysql_enable_MenuItem";
            this.mysql_enable_MenuItem.Size = new System.Drawing.Size(163, 22);
            this.mysql_enable_MenuItem.Text = "Enable";
            this.mysql_enable_MenuItem.Click += new System.EventHandler(this.EnableMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpStripMenuItem_Click);
            // 
            // progressValue_Label
            // 
            this.progressValue_Label.AutoSize = true;
            this.progressValue_Label.BackColor = System.Drawing.SystemColors.Control;
            this.progressValue_Label.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressValue_Label.Location = new System.Drawing.Point(332, 245);
            this.progressValue_Label.Name = "progressValue_Label";
            this.progressValue_Label.Size = new System.Drawing.Size(21, 13);
            this.progressValue_Label.TabIndex = 5;
            this.progressValue_Label.Text = "0%";
            this.progressValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pagePanel
            // 
            this.pagePanel.Location = new System.Drawing.Point(0, 27);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(686, 215);
            this.pagePanel.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 261);
            this.Controls.Add(this.pagePanel);
            this.Controls.Add(this.progressValue_Label);
            this.Controls.Add(this.ScanProgressBar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(702, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(702, 300);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enigma2 Tester";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar ScanProgressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTPSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mysql_enable_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testerToolStripMenuItem;
        private System.Windows.Forms.Label progressValue_Label;
        private System.Windows.Forms.Panel pagePanel;
    }
}

