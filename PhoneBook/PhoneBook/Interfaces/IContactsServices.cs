namespace PhoneBook.Interfaces
{
    internal interface IContactsServices
    {
        /// <summary>
        /// Method generates array of IContact randomle, based on existing enums.
        /// </summary>
        /// <param name="length">Length of array.</param>
        /// <returns>Array of random IContacts.</returns>
        IContact[] GenerateContactList(int length);
    }
}