using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLINQ.LINQ
{
    internal class LINQToys
    {
        public LINQToys()
        {
            ContactList = new List<Contact>()
            {
                new Contact("Japan", 123),
                new Contact("Den", 456),
                new Contact("Den", 123)
            };
            var stiv = new Contact("Stiv", 999);
            ContactList.Add(stiv);

            var firstOrDefault = ContactList.FirstOrDefault<Contact>(x => x.Name == "Den");
            var where = ContactList.Where<Contact>(x => x.Name.ToLower() == "den").ToList();
            var orderBy = ContactList.OrderBy<Contact, string>(x => x.Name).ThenBy<Contact, int>(x => x.Phone).ToList();
            var contains1 = ContactList.Contains<Contact>(stiv);
            var contains2 = ContactList.Contains<Contact>(new Contact("Stiv", 999));
        }

        public List<Contact> ContactList { get; set; }
    }
}
