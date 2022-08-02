using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWAndRepositoryWithMongoAndSql.Repositories
{
    using Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class SqlRepository : DbContext, IDbRepository
    {
        private readonly string _connectionString;


        public SqlRepository()
        {
            _connectionString = Environment.GetEnvironmentVariable("AdventureDbConnection");
        }

        public SqlRepository(DbContextOptions<SqlRepository> options)
            : base(options)
        {

        }

        public async Task DeleteById<TModel>(int id)
            where TModel : class
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TModel>> GetAll<TModel>()
            where TModel : class
        {
            throw new NotImplementedException();
        }

        public Task<TModel> GetById<TModel>(int id)
            where TModel : class
        {
            throw new NotImplementedException();
        }

        public Task InsertMany<TModel>(IEnumerable<TModel> models)
            where TModel : class
        {
            throw new NotImplementedException();
        }

        public Task InsertOne<TModel>(TModel model)
            where TModel : class
        {
            throw new NotImplementedException();
        }

        public Task UpdateOne<TModel>(TModel model)
            where TModel : class
        {
            throw new NotImplementedException();
        }
    }
}
