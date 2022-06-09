using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook.Interfaces;
using PhoneBook.Models;
using PhoneBook.Services;

namespace PhoneBook.Services
{
    internal class Run
    {
        public Run(IContactsServices contactServices, IPhoneBookServices phoneBookServices)
        {
            IContact[] cl = contactServices.GenerateContactList(40);
            var phoneBook = phoneBookServices.TransformContactListToPhoneBook(cl, new CultureInfo("uk-UA", false));
            phoneBookServices.ShowPhoneBook(phoneBook);
        }
    }
}
