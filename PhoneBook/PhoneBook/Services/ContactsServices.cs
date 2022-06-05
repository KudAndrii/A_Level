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
            IContact[] contacsArray = new Contact[length];
            for (int i = 0; i < length - 1; i++)
            {
                contacsArray[i] = new Contact(((Names)_random.Next(0, 18)).ToString(), ((Surnames)_random.Next(0, 7)).ToString(), _random.Next(600000000, 999999999));
            }

            contacsArray[length - 1] = new Contact(((Names)_random.Next(0, 9)).ToString(), "911", _random.Next(600000000, 999999999));
            return contacsArray;
        }
    }
}
