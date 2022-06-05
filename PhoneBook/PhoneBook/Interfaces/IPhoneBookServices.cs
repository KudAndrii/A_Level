using System.Collections.Generic;

namespace PhoneBook.Interfaces
{
    internal interface IPhoneBookServices
    {
        void ShowPhoneBook(Dictionary<string, List<IContact>> phoneBook);
        Dictionary<string, List<IContact>> TransformContactListToPhoneBook(IContact[] contacsArray, string cultureInfo);
    }
}