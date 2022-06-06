using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook.Interfaces;
using PhoneBook.Models;

namespace PhoneBook.Services
{
    internal class PhoneBookServices : IPhoneBookServices
    {
        private readonly JSConfig _jsConfig;
        public PhoneBookServices(JSConfig jsConfig)
        {
            _jsConfig = jsConfig;
        }

        public Dictionary<string, List<IContact>> TransformContactListToPhoneBook(IContact[] contactsArray, CultureInfo cultureInfo)
        {
            var phoneBook = CreateStartedDictionary(cultureInfo);
            for (int i = 0; i < contactsArray.Length; i++)
            {
                string key = contactsArray[i].Surname[0].ToString().ToUpper();
                if (phoneBook.ContainsKey(key))
                {
                    phoneBook[key].Add(contactsArray[i]);
                }
                else if (char.IsNumber(key, 0))
                {
                    phoneBook["0-9"].Add(contactsArray[i]);
                }
                else
                {
                    phoneBook["#"].Add(contactsArray[i]);
                }
            }

            SortPhoneBook(phoneBook, cultureInfo);
            return phoneBook;
        }

        public void ShowPhoneBook(Dictionary<string, List<IContact>> phoneBook)
        {
            foreach (var kvp in phoneBook)
            {
                if (kvp.Value.Count > 0)
                {
                    Console.Write(kvp.Key);
                    foreach (var contact in kvp.Value)
                    {
                        Console.WriteLine("\t" + contact.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Method creates keys and empty lists of IContacts, based on incoming info about main language.
        /// </summary>
        /// <param name="cultureInfo">Incoming info about main language.</param>
        /// <returns>Dictionary with all needed keys and empty lists of IContacts.</returns>
        private Dictionary<string, List<IContact>> CreateStartedDictionary(CultureInfo cultureInfo)
        {
            var result = new Dictionary<string, List<IContact>>();
            if (cultureInfo.Name == "en-US")
            {
                for (int i = 0; i < _jsConfig.Alphabets.AlphabetEN.Length; i++)
                {
                    result.Add(_jsConfig.Alphabets.AlphabetEN[i].ToString(), new List<IContact>());
                }
            }
            else if (cultureInfo.Name == "ru-RU")
            {
                for (int i = 0; i < _jsConfig.Alphabets.AlphabetRU.Length; i++)
                {
                    result.Add(_jsConfig.Alphabets.AlphabetRU[i].ToString(), new List<IContact>());
                }
            }

            result.Add("#", new List<IContact>());
            result.Add("0-9", new List<IContact>());
            return result;
        }

        /// <summary>
        /// Method sorts every list of IContacts in phone book, based on incoming info about main language.
        /// </summary>
        /// <param name="phoneBook">Incoming dictionary of IContacts.</param>
        /// <param name="cultureInfo">Incoming info about main language.</param>
        private void SortPhoneBook(Dictionary<string, List<IContact>> phoneBook, CultureInfo cultureInfo)
        {
            foreach (var item in phoneBook)
            {
                for (int i = 0; i < item.Value.Count - 1; i++)
                {
                    for (int j = i + 1; j < item.Value.Count; j++)
                    {
                        if (cultureInfo.CompareInfo.Compare(item.Value[i].Surname + item.Value[i].Name, item.Value[j].Surname + item.Value[j].Name) > 0)
                        {
                            var k = item.Value[i];
                            item.Value[i] = item.Value[j];
                            item.Value[j] = k;
                        }
                    }
                }
            }
        }
    }
}
