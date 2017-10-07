using System;
using System.Windows.Forms;
using Enigma2_stream_tester.Utils;

namespace Enigma2_stream_tester.UserView
{
    public partial class FtpPage : UserControl
    {
        public bool ConnectionStatus;
        public Ftp Client;
        public string ChoosenFolder;
        private readonly Main _form;

        public FtpPage(Main form)
        {
            _form = form;
            InitializeComponent();
        }

        private void Ftp_CheckedChanged(object sender, EventArgs e)
        {
            if (ftp_checkBox.Checked)
            {
                ftpLink_Textbox.Enabled = true;
                ftpLogin_Textbox.Enabled = true;
                ftpLogin_Button.Enabled = true;
                ftpPassword_Textbox.Enabled = true;
            }
            else
            {
                ftpLink_Textbox.Enabled = false;
                ftpLogin_Button.Enabled = false;
                ftpLogin_Textbox.Enabled = false;
                ftpPassword_Textbox.Enabled = false;
            }
        }

        private void ConnectToFtp(string login, string password, string ip)
        {
            try
            {
                Client = new Ftp(ip, login, password);
                var ftpDirectores = Client.DirectoryListSimple("");
                if (ftpDirectores[0] == "")
                {
                    ftpDirectory_comboBox.Enabled = false;
                    MessageBox.Show(@"Cannot connect to ftp server!", @"Error!");
                }
                else
                {
                    ConnectionStatus = true;
                    ftpDirectory_comboBox.Enabled = true;
                    foreach (var item in ftpDirectores)
                    {
                        if (!item.Contains(".") && item != string.Empty)
                        {
                            ftpDirectory_comboBox.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                _form.AddLogToFile(e.ToString());
            }
        }

        private void FtpLogin_Button_Click(object sender, EventArgs e)
        {
            if (ftpLogin_Textbox.Text == string.Empty || ftpPassword_Textbox.Text == string.Empty ||
                ftpLink_Textbox.Text == string.Empty)
            {
                MessageBox.Show(@"Ops! First you need to type connection parameters!", @"Error!");
            }
            else
            {
                ConnectToFtp(ftpLogin_Textbox.Text, ftpPassword_Textbox.Text, ftpLink_Textbox.Text);
            }
        }

        private void FtpDirectory_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChoosenFolder = ftpDirectory_comboBox.SelectedItem.ToString();
        }
    }
}
