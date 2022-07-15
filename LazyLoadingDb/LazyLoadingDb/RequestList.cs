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
    using Microsoft.Data.SqlClient;

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

            var employeesDates = _db.Employees.Select(x => DateTime.Now.Subtract(x.HiredDate));
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

        public void AddFullEmployeeAndProjectEntity(Employee e, Project p)
        {
            Console.WriteLine("Request #3");

            _db.Employees.Add(e);
            _db.Projects.Add(p);
        }

        public void DeleteSomeEmployee(int id)
        {
            Console.WriteLine("Request #4");

            var entityForRemove = _db.Employees.SingleOrDefault(e => e.EmployeeId == id);
            if (entityForRemove != null)
            {
                _db.Employees.Remove(entityForRemove);
            }
        }

        public void GroupByTitle(char condition)
        {
            Console.WriteLine("Request #5");


        }

        public void SelectTwoConnectedEntites()
        {
            Console.WriteLine("Request #6");

            var forOutput = _db.Employees.SingleOrDefault(x => x.EmployeeId == 1);
            Console.WriteLine($"{forOutput?.FirstName ?? "Entity is not exist"} {forOutput?.LastName} {forOutput?.Title.Name}");
        }
    }
}
