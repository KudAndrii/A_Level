using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLINQ.LINQ
{
    internal class Contact
    {
        public Contact(string name, int phone)
        {
            Name = name;
            Phone = phone;
        }

        public string Name { get; }
        public int Phone { get; }
    }
}
