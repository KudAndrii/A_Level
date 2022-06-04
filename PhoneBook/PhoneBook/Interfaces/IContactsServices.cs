using PhoneBook.Models;

namespace PhoneBook.Interfaces
{
    internal interface IContactsServices
    {
        IContact[] GeneratePhoneBook(int length);
    }
}