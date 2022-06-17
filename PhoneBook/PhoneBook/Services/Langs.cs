using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Services
{
    /// <summary>
    /// Class for Deserealization json's file with alphabets.
    /// </summary>
    internal class Langs
    {
        public string DefaultCulture { get; set; }
        public Dictionary<string, string> Alphabets { get; set; }
    }
}
