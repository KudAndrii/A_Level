using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWAndRepositoryWithMongoAndSql.Interfaces
{
    public interface DbRepository
    {
        public Task<TModel> GetById<TModel>(int id);
        public Task<IEnumerable<TModel>> GetAll<TModel>();
        public Task InsertOne<TModel>(TModel model);
        public Task InsertMany<TModel>(IEnumerable<TModel> models);
        public Task UpdateOne<TModel>(TModel model);
        public Task DeleteById<TModel>(int id);
    }
}
