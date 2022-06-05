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
        private const string _alphabetEN = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string _alphabetRU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

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

            foreach (var kvp in phoneBook)
            {
                SortList(kvp.Value, cultureInfo);
            }

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
            if (cultureInfo.Name == new CultureInfo("en-US", false).Name)
            {
                for (int i = 0; i < _alphabetEN.Length; i++)
                {
                    result.Add(_alphabetEN[i].ToString(), new List<IContact>());
                }
            }
            else if (cultureInfo.Name == new CultureInfo("ru-RU", false).Name)
            {
                for (int i = 0; i < _alphabetRU.Length; i++)
                {
                    result.Add(_alphabetRU[i].ToString(), new List<IContact>());
                }
            }

            result.Add("#", new List<IContact>());
            result.Add("0-9", new List<IContact>());
            return result;
        }

        /// <summary>
        /// Method sorts list of IContacts, based on incoming info about main language.
        /// </summary>
        /// <param name="contactsList">Incoming list of IContacts.</param>
        /// <param name="cultureInfo">Incoming info about main language.</param>
        private void SortList(List<IContact> contactsList, CultureInfo cultureInfo)
        {
            for (int i = 0; i < contactsList.Count - 1; i++)
            {
                for (int j = i + 1; j < contactsList.Count; j++)
                {
                    if (cultureInfo.CompareInfo.Compare(contactsList[i].Surname + contactsList[i].Name, contactsList[j].Surname + contactsList[j].Name) > 0)
                    {
                        var k = contactsList[i];
                        contactsList[i] = contactsList[j];
                        contactsList[j] = k;
                    }
                }
            }
        }
    }
}
