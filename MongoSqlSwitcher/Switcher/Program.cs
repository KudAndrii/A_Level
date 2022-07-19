namespace Switcher
{
    using DbConnectors;
    using Models;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees;
            using (var sqlDb = new AdventureWorks2019SqlContext())
            {
                var someEmployees = sqlDb.Employees.Select(x => x).Where(x => x.BusinessEntityId <= 10);
                Employees = someEmployees.ToList();
            }

            var MongoDb = new AdventureWorks2019MongoConnection();

            MongoDb.Employees.InsertManyAsync(Employees);
        }
    }
}