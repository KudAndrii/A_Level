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

        public IContact[] GeneratePhoneBook(int length)
        {
            IContact[] phoneBook = new Contact[length];
            for (int i = 0; i < length; i++)
            {
                phoneBook[i] = new Contact(((Names)_random.Next(0, 9)).ToString(), ((Surnames)_random.Next(0, 4)).ToString(), _random.Next(600000000, 999999999));
            }

            return phoneBook;
        }
    }
}
