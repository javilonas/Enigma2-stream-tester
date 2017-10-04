using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Enigma2_stream_tester.Utils
{
    internal class Configuration
    {
        private readonly Main _form;

        public Configuration(Main form)
        {
            _form = form;
        }

        public void SaveJson()
        {
            var config = JsonConvert.SerializeObject(_form.LoadJson()); 
        }
    }
}
