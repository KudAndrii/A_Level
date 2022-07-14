using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingDb.Interfaces
{
    using LazyLoadingDb.Models;
    using LazyLoadingDb.DatabaseContext;
    internal interface IRequestList
    {
        /// <summary>
        /// Method outputs difference between hireddates of employees and now in targeted database.
        /// </summary>
        public void DateDifference();

        /// <summary>
        /// Method updates 2 entites in targeted database.
        /// </summary>
        public void ModifyEntites();
        public void AddFullEmployeeEntity(Employee e, Title t, Project p);
        public void DeleteSomeEmployee(int id);
        public void GroupByTitle(char condition);
        public void SelectTwoConnectedEntites();

    }
}
