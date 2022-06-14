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

            var firstOrDefault = ContactList.FirstOrDefault(x => x.Name == "Den");
            var where = ContactList.Where(x => x.Name.ToLower() == "den").ToList();
            var orderBy = ContactList.OrderBy(x => x.Name).ThenBy<Contact, int>(x => x.Phone).ToList();
            var contains1 = ContactList.Contains(stiv);
            var contains2 = ContactList.Contains(new Contact("Stiv", 999));
            var select = ContactList.Select(x => x.Name).ToList();
            var groupBy = ContactList.OrderBy(x => x.Name).ThenBy(x => x.Phone).GroupBy(x => x.Name[0]).Select(x => x).OrderBy(x => x.Key).ToList();
        }

        public List<Contact> ContactList { get; set; }
    }
}
