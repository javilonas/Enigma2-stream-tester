using Newtonsoft.Json;

namespace Enigma2_stream_tester.Utils
{
    internal class Configuration
    {
        //private
        private readonly Main _form;

        public Configuration(Main form)
        {
            _form = form;
        }

        public void SaveJson()
        {
            JsonConvert.SerializeObject(_form.LoadJson()); 
        }
    }
}
