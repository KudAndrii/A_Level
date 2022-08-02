using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWAndRepositoryWithMongoAndSql.Interfaces
{
    internal interface IUnitOfWork
    {
        public IDbRepository MongoContext { get; }
        public IDbRepository SqlContext { get; }
        public Task SaveAllChanges();
    }
}
