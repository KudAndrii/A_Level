using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWAndRepositoryWithMongoAndSql.Interfaces
{
    internal interface UnitOfWork
    {
        public Task SaveAllChanges();
    }
}
