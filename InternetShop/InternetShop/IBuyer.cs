using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop
{
    internal interface IBuyer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}
