using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook.Interfaces;

namespace PhoneBook.Models
{
    internal class Contact : IContact
    {
        public Contact(string name, string surname, int phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; init; }
        public string Surname { get; init; }
        public int PhoneNumber { get; init; }

        /// <summary>
        /// Method for simple output info about contact.
        /// </summary>
        /// <returns>Concatination of Surname, Name and phone number.</returns>
        public override string ToString()
        {
            return $"{Surname ?? string.Empty} {Name ?? string.Empty}\n\t0{PhoneNumber}";
        }
    }
}
