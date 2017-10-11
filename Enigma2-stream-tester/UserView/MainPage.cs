using System;
using System.Windows.Forms;

namespace Enigma2_stream_tester.UserView
{
    public partial class MainPage : UserControl
    {
        private readonly Main _form;

        public MainPage(Main form)
        {
            _form = form;
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            _form.Start_Click(sender,e);
        }
    }
}
