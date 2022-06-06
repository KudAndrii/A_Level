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
        private Alphabets _alphabets;

        public JSConfig()
        {
            _alphabets = DeserializingAlphabets();
            Languages = GetAllAlphabets();
        }

        /// <summary>
        /// Gets KPV, where key is name of language.
        /// </summary>
        /// <value>
        /// Corresponding alphabet.
        /// </value>
        public Dictionary<string, string> Languages { get; }

        /// <summary>
        /// Method gets information from json file with alphabets.
        /// </summary>
        /// <returns>Example of Alphabets with existing info from json file.</returns>
        public Alphabets DeserializingAlphabets()
        {
            var alphabetConfig = File.ReadAllText(@"..\..\..\AlphabetsJS\AlphabetConfig.json");
            return JsonConvert.DeserializeObject<Alphabets>(alphabetConfig);
        }

        /// <summary>
        /// Method transforms example of class Alphabets to comfortable Dictionary of alphabets.
        /// </summary>
        /// <returns>Dictionary, where Key is name of language and Value is corresponding alphabet.</returns>
        private Dictionary<string, string> GetAllAlphabets()
        {
            var result = new Dictionary<string, string>();
            Type type = _alphabets.GetType();
            var propertys = type.GetProperties();
            foreach (var property in propertys)
            {
                if (property.Name.Contains("Alphabet"))
                {
                    result.Add(property.Name.Substring(property.Name.Length - 2).ToLower(), property.GetValue(_alphabets).ToString());
                }
            }

            return result;
        }
    }
}
