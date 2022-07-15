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

        public void AddFullEmployeeAndProjectEntity(Employee e, Project p)
        {
            Console.WriteLine("Request #3");

            var employees = _db.Employees.Select(e => e);
            if (!employees.Contains(e))
            {
                _db.Employees.Add(e);
            }

            var projects = _db.Projects.Select(p => p);
            if (!projects.Contains(p))
            {
                _db.Projects.Add(p);
            }
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
            Console.WriteLine($"{forOutput?.FirstName} {forOutput?.LastName} {forOutput?.Title.Name}");
        }
    }
}
