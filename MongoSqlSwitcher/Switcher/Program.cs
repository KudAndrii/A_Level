namespace Switcher
{
    using DbConnectors;
    using Models;
    internal class Program
    {
        static async Task Main(string[] args)
        {
            /*
            Task<IQueryable<Employee>> Employees;
            using (var sqlDb = new AdventureWorks2019SqlContext())
            {

                Employees = Task.Run(() =>
                {
                    return sqlDb.Employees.Select(x => x).Where(x => x.BusinessEntityId <= 10);
                });

                var MongoDb = new AdventureWorks2019MongoConnection();

                MongoDb.Employees.InsertMany(await Employees);
            }
            */



        }
    }
}