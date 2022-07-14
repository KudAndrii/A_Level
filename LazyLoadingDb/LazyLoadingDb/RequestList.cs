using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingDb
{
    using LazyLoadingDb.DatabaseContext;
    using LazyLoadingDb.Interfaces;
    using LazyLoadingDb.Models;

    internal class RequestList : IRequestList
    {
        private readonly FirstDatabaseContext _db;
        public RequestList(FirstDatabaseContext db)
        {
            _db = db;
        }

        public void DateDifference()
        {
            Console.WriteLine("Request #1");

            IQueryable<Employee> employees = _db.Employees.Select(x => x);
            foreach (var employee in employees)
            {
                Console.WriteLine(DateTime.Now.Subtract(employee.HiredDate));
            }
        }

        public void ModifyEntites()
        {
            Console.WriteLine("Request #2");

            IQueryable<Employee> employees = _db.Employees.Select(x => x).Take(2);
            foreach (var employee in employees)
            {
                employee.LastName = "Strange";
            }
        }

        public void AddFullEmployeeEntity(Employee e, Title t, Project p)
        {
            _db.Titles.Add(new Title
            {

            });
        }

        public void DeleteSomeEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void GroupByTitle(char condition)
        {
            throw new NotImplementedException();
        }

        public void SelectTwoConnectedEntites()
        {
            throw new NotImplementedException();
        }
    }
}
