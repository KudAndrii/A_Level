using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWAndRepositoryWithMongoAndSql
{
    using Interfaces;
    using Repositories;
    public class UOW : IUnitOfWork
    {
        private Lazy<MongoRepository> _mongoContext = new Lazy<MongoRepository>();
        private Lazy<SqlRepository> _sqlContext = new Lazy<SqlRepository>();

        public IDbRepository MongoContext
        {
            get { return _mongoContext.Value; }
        }
        public IDbRepository SqlContext
        {
            get { return _sqlContext.Value; }
        }

        public Task SaveAllChanges()
        {
            throw new NotImplementedException();
        }
    }
}
