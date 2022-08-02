using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWAndRepositoryWithMongoAndSql.Interfaces
{
    public interface IDbRepository
    {
        public Task<TModel> GetById<TModel>(int id)
            where TModel : class;
        public Task<IEnumerable<TModel>> GetAll<TModel>()
            where TModel : class;
        public Task InsertOne<TModel>(TModel model)
            where TModel : class;
        public Task InsertMany<TModel>(IEnumerable<TModel> models)
            where TModel : class;
        public Task UpdateOne<TModel>(TModel model)
            where TModel : class;
        public Task DeleteById<TModel>(int id)
            where TModel : class;
    }
}
