using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using PhoneBook.Models;
using PhoneBook.Enums;
using PhoneBook.Interfaces;

namespace PhoneBook.Services
{
    internal class ContactsServices : IContactsServices
    {
        private readonly Random _random;
        public ContactsServices(Random random)
        {
            _random = random;
        }

        public IContact[] GenerateContactList(int length)
        {
            IContact[] contactsArray = new Contact[length];

            // Random Name, based on existing corresponding enum.
            string randomName;

            // Random Surname, based on existing corresponding enum.
            string randomSurname;

            // Random phone number.
            int randomPhoneNumber;
            for (int i = 0; i < length; i++)
            {
                randomName = ((Names)_random.Next(0, 18)).ToString();
                randomSurname = ((Surnames)_random.Next(0, 9)).ToString();
                randomPhoneNumber = _random.Next(600000000, 999999999);
                contactsArray[i] = new Contact(randomName, randomSurname, randomPhoneNumber);
            }

            return contactsArray;
        }
    }
}
