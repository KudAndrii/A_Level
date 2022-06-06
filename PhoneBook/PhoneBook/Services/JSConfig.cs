using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PhoneBook.Services
{
    internal class JSConfig
    {
        public JSConfig()
        {
            Alphabets = DeserializingAlphabets();
        }

        public Alphabets Alphabets { get; }

        public Alphabets DeserializingAlphabets()
        {
            var alphabetConfig = File.ReadAllText(@"..\..\..\AlphabetsJS\AlphabetConfig.json");
            return JsonConvert.DeserializeObject<Alphabets>(alphabetConfig);
        }
    }
}
