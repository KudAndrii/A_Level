using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PhoneBook.Services
{
    internal class JSConfig
    {
        public JSConfig()
        {
            Langs = DeserializingAlphabets();
        }

        public Langs Langs { get; set; }

        /// <summary>
        /// Method gets information from json file with alphabets.
        /// </summary>
        /// <returns>Example of Alphabets with existing info from json file.</returns>
        public Langs DeserializingAlphabets()
        {
            var alphabetConfig = File.ReadAllText(@"..\..\..\AlphabetsJS\AlphabetConfig.json");
            return JsonConvert.DeserializeObject<Langs>(alphabetConfig);
        }
    }
}
