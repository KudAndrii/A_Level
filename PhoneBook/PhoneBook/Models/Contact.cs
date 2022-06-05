using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook.Interfaces;

namespace PhoneBook.Models
{
    internal class Contact : IContact, IComparable
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

        public int CompareTo(object obj)
        {
            if (obj is Contact contact)
            {
                return Surname.CompareTo(contact.Surname);
            }
            else
            {
                throw new ArgumentException("Argument is not a Contact");
            }
        }

        public override string ToString()
        {
            return $"{Surname ?? string.Empty} {Name ?? string.Empty}\n\t0{PhoneNumber}";
        }
    }
}
