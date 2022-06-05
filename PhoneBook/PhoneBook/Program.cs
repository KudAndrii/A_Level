using System;
using System.Globalization;
using PhoneBook.Services;
using PhoneBook.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace PhoneBook
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DIContainer container = new DIContainer();
            var load = container.Load();
            IContactsServices cs = load.GetService<IContactsServices>();
            IContact[] cl = cs.GenerateContactList(20);
            IPhoneBookServices ps = load.GetService<IPhoneBookServices>();
            var phoneBook = ps.TransformContactListToPhoneBook(cl, "en-us");
            ps.ShowPhoneBook(phoneBook);
        }
    }
}
