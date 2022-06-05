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

        public Dictionary<string, List<IContact>> TransformContactListToPhoneBook(IContact[] contacsArray, string cultureInfo)
        {
            var phoneBook = CreateStartedDictionary(cultureInfo);
            for (int i = 0; i < contacsArray.Length; i++)
            {
                string key = contacsArray[i].Surname[0].ToString().ToUpper();
                if (phoneBook.ContainsKey(key))
                {
                    phoneBook[key].Add(contacsArray[i]);
                }
                else if (char.IsNumber(key, 0))
                {
                    phoneBook["0-9"].Add(contacsArray[i]);
                }
                else
                {
                    phoneBook["#"].Add(contacsArray[i]);
                }
            }

            foreach (var kvp in phoneBook)
            {
                SortList(kvp.Value);
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

        private Dictionary<string, List<IContact>> CreateStartedDictionary(string cultureInfo)
        {
            var result = new Dictionary<string, List<IContact>>();
            if (cultureInfo.ToUpper() == "EN-US")
            {
                for (int i = 0; i < _alphabetEN.Length; i++)
                {
                    result.Add(_alphabetEN[i].ToString(), new List<IContact>());
                }
            }
            else if (cultureInfo.ToUpper() == "RU-RU")
            {
                for (int i = 0; i < _alphabetRU.Length; i++)
                {
                    result.Add(_alphabetEN[i].ToString(), new List<IContact>());
                }
            }

            result.Add("#", new List<IContact>());
            result.Add("0-9", new List<IContact>());
            return result;
        }

        private void SortList(List<IContact> contactsList)
        {
            for (int i = 0; i < contactsList.Count - 1; i++)
            {
                for (int j = i + 1; j < contactsList.Count; j++)
                {
                    if ((contactsList[i] as Contact).CompareTo(contactsList[j]) > 0)
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
