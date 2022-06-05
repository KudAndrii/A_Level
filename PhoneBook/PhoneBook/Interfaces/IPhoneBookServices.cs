using System.Collections.Generic;
using System.Globalization;

namespace PhoneBook.Interfaces
{
    internal interface IPhoneBookServices
    {
        /// <summary>
        /// Method outputs all contacts from phone book in console.
        /// </summary>
        /// <param name="phoneBook">Incming phone book.</param>
        void ShowPhoneBook(Dictionary<string, List<IContact>> phoneBook);

        /// <summary>
        /// Method transform incoming array of IContacts to Dictionary, where Key is first letter of main lenguage, Value is List of IContacts>.
        /// </summary>
        /// <param name="contacsArray">Incoming array of IContacts.</param>
        /// <param name="cultureInfo">Info about main language in phone book.</param>
        /// <returns>Phone book as dictionary.</returns>
        Dictionary<string, List<IContact>> TransformContactListToPhoneBook(IContact[] contacsArray, CultureInfo cultureInfo);
    }
}