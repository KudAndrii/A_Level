namespace Switcher
{
    using DbConnectors;
    using Models;
    using Models.CustomModels;
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var db = new AdventureWorks2019MongoConnection();
            await db.DeleteAllUsersAsync();
        }
    }
}