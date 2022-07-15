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

        /// <summary>
        /// Method adds Employee entity and Title entity, which connected with it, and Project entity to targeted database.
        /// </summary>
        /// <param name="e">Incoming Employee entity.</param>
        /// <param name="p">Incoming Project entity.</param>
        public void AddFullEmployeeAndProjectEntity(Employee e, Project p);

        /// <summary>
        /// Method deletes Employee entity from targeted database.
        /// </summary>
        /// <param name="id">Incoming id.</param>
        public void DeleteSomeEmployee(int id);

        /// <summary>
        /// Method groups employees by titles from targeted database and returns if it meets the incoming confition.
        /// </summary>
        /// <param name="condition">Icnoming condition.</param>
        public void GroupByTitle(char condition);

        /// <summary>
        /// Method outputs some info from 2 connected tables from targeted database.
        /// </summary>
        public void SelectTwoConnectedEntites();
    }
}
