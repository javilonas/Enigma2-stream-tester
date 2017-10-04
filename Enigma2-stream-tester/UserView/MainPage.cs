using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma2_stream_tester.UserView
{
    public partial class MainPage : UserControl
    {
        private Main _form;
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
