using System;
using System.Collections.Generic;
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
        public override string ToString()
        {
            return $"{Surname} {Name}\n0{PhoneNumber}";
        }
    }
}
