using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Enigma2_stream_tester.UserView
{
    public partial class MainConfigView : UserControl
    {
        private readonly Main _form;
        private List<Data> _channelsConfigContentList;
        private readonly List<string> _channelsLinks = new List<string>();
        private readonly List<string> _channelsNames = new List<string>();

        public MainConfigView(Main form)
        {
            InitializeComponent();
            cfgChannels_comboBox.Enabled = false;
            _form = form;
            _form.LoadJson();
            Config();
            _channelsConfigContentList = LoadChannelsContent();
            FindCurrentChannel(_channelsConfigContentList);
        }

        private void Config()
        {
            Timeout_Trackbar.Value = _form.ConfigurationItems[0].timeout;
            Speed_Trackbar.Value = _form.ConfigurationItems[0].parallelOpt;
            Timeout_Value.Text = Timeout_Trackbar.Value.ToString();
            Speed_Value.Text = Speed_Trackbar.Value.ToString();

            if (_form.ConfigurationItems[0].scanPort == "8001")
            {
                Port8001_Checkbox.Checked = true;
                Port8002_Checkbox.Checked = false;
            }
            else
            {
                Port8002_Checkbox.Checked = true;
                Port8001_Checkbox.Checked = false;
            }
        }

        public struct Data
        {
            public Data(string List, string[] strValue)
            {
                PathData = List;
                StringData = strValue;
            }

            public string PathData { get; private set; }
            public string[] StringData { get; private set; }
        }

        private List<Data> LoadChannelsContent()
        {
            _channelsConfigContentList = new List<Data>();
            var list = new List<Data>();
            var counter = 0;
            foreach (var item in Directory.GetFiles(Directory.GetCurrentDirectory() + "\\configs", "*.channels"))
            {
                var content = File.ReadAllLines(item);
                var test = Directory.GetFiles(Directory.GetCurrentDirectory() + "\\configs", "*.channels");
                list.Add(new Data(test[counter].Remove(0, test[counter].LastIndexOf("\\", StringComparison.Ordinal)+1),content));
                counter += 1;
            }
            return list;
        }

        private void TimeoutValue_Changed(object sender, EventArgs e)
        {
            Timeout_Value.Text = Timeout_Trackbar.Value.ToString();
        }

        private void FindCurrentChannel(IEnumerable<Data> listOfChannels)
        {
            var channel = _form.ConfigurationItems[0].defaultChannel;
            foreach (var item in listOfChannels)
            {
                cfgLists_comboBox.Items.Add(item.PathData.Replace(".channels", string.Empty));
                var index = Array.IndexOf(item.StringData, channel);
                if (index > -1)
                {
                    cfgLists_comboBox.SelectedText = item.PathData.Replace(".channels",string.Empty);
                    var dot = item.StringData[index - 1].LastIndexOf(",", StringComparison.Ordinal);
                    var newChannel = item.StringData[index - 1].Remove(0, dot + 1);
                    cfgChannels_comboBox.SelectedText = newChannel;
                }
            }
        }

        private void Speed_ValueChanged(object sender, EventArgs e)
        {
            Speed_Value.Text = Speed_Trackbar.Value.ToString();
        }

        private void Port8002_CheckChanged(object sender, EventArgs e)
        {
            if (Port8001_Checkbox.Checked)
            {
                Port8002_Checkbox.Checked = false;
            }
        }

        private void Port8001_CheckChanged(object sender, EventArgs e)
        {
            if (Port8002_Checkbox.Checked)
            {
                Port8001_Checkbox.Checked = false;
            }
        }

        private void Channel_IndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cfgChannels_comboBox.SelectedIndex;

            if (selectedIndex == -1)
            {
                return;
            }
            else
            {
                _form.ConfigurationItems[0].defaultChannel = _channelsLinks[selectedIndex];
            }
        }

        private void List_IndexChanged(object sender, EventArgs e)
        {
            cfgChannels_comboBox.Enabled = true;
            cfgChannels_comboBox.Items.Clear();
            var channel = _form.ConfigurationItems[0].defaultChannel;
            foreach (var item in _channelsConfigContentList)
            {
                if(item.PathData.Equals(cfgLists_comboBox.SelectedItem+".channels"))
                {
                    foreach (var line in item.StringData)
                    {
                        if (line.StartsWith("/1:0"))
                        {
                            _channelsLinks.Add(line);
                        }
                        else
                        {
                            var dot = line.LastIndexOf(",", StringComparison.Ordinal);
                            var newChannel = line.Remove(0, dot + 1);
                            _channelsNames.Add(newChannel);
                        }
                    }
                    foreach (var channelName in _channelsNames)
                    {
                        cfgChannels_comboBox.Items.Add(channelName);
                    }
                }
            }
        }
    }
}
