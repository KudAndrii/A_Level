using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Interfaces
{
    public interface IContact
    {
        public string Name { get; init; }
        public string Surname { get; init; }
        public int PhoneNumber { get; init; }
    }
}
