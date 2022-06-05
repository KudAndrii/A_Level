namespace PhoneBook.Interfaces
{
    internal interface IContactsServices
    {
        IContact[] GenerateContactList(int length);
    }
}