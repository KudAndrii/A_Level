using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWAndRepositoryWithMongoAndSql.Repositories
{
    using Interfaces;
    public class SqlRepository : DbRepository
    {
        public Task DeleteById<TModel>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetAll<TModel>()
        {
            throw new NotImplementedException();
        }

        public Task<TModel> GetById<TModel>(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertMany<TModel>(IEnumerable<TModel> models)
        {
            throw new NotImplementedException();
        }

        public Task InsertOne<TModel>(TModel model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOne<TModel>(TModel model)
        {
            throw new NotImplementedException();
        }
    }
}
