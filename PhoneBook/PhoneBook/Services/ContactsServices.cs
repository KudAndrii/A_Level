using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using PhoneBook.Models;
using PhoneBook.Interfaces;

namespace PhoneBook.Services
{
    internal class ContactsServices : IContactsServices
    {
        private readonly Random _random;
        private readonly List<string> _names = new List<string>()
        {
        "Андрей",
        "Антон",
        "Вася",
        "Виктор",
        "Петя",
        "Павел",
        "Дима",
        "Денис",
        "Гриша",
        "Andrew",
        "Anton",
        "Vasya",
        "Viktor",
        "John",
        "Jorj",
        "Stiven",
        "Stifler",
        "Kate"
        };
        private readonly List<string> _surnames = new List<string>()
        {
        "Smit",
        "Shmidt",
        "Galager",
        "Geller",
        "Попов",
        "Павлов",
        "Климов",
        "911"
        };

        public ContactsServices(Random random)
        {
            _random = random;
        }

        public IContact[] GenerateContactList(int length)
        {
            IContact[] contactsArray = new Contact[length];

            // Random Name, based on existing corresponding array.
            string randomName;

            // Random Surname, based on existing corresponding array.
            string randomSurname;

            // Random phone number.
            int randomPhoneNumber;
            for (int i = 0; i < length; i++)
            {
                randomName = _names[_random.Next(0, 18)];
                randomSurname = _surnames[_random.Next(0, 8)];
                randomPhoneNumber = _random.Next(600000000, 999999999);
                contactsArray[i] = new Contact(randomName, randomSurname, randomPhoneNumber);
            }

            return contactsArray;
        }
    }
}
