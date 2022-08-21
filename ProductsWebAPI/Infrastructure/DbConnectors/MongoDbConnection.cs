using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DbConnectors
{
    using Core;
    using Infrastructure.Interfaces;
    using MongoDB.Driver;
    public class MongoDbConnection : IDbRepository
    {
        private readonly string _connectionString;
        private readonly string _databaseName;
        private const string _productCollection = "products";

        public MongoDbConnection(IConfigService configService)
        {
            _connectionString = configService.MongoDbInfo.ConnectionString;
            _databaseName = configService.MongoDbInfo.DbName;
        }

        public async Task<List<ProductModel>> GetAllAsync()
        {
            var productCollection = ConnectToMongo<ProductModel>(_productCollection);
            var result = await productCollection.FindAsync(_ => true);

            return result.ToList();
        }

        public async Task<ProductModel> GetByIdAsync(int id)
        {
            var productList = await GetAllAsync();
            return productList.FirstOrDefault(p => p.ProductId == id);
        }

        public async Task InsertOneAsync(ProductModel model)
        {
            var productCollection = ConnectToMongo<ProductModel>(_productCollection);
            await productCollection.InsertOneAsync(model);
        }

        public async Task UpdateOneAsync(ProductModel model)
        {
            var productCollection = ConnectToMongo<ProductModel>(_productCollection);
            var filter = Builders<ProductModel>.Filter.Eq("ProductId", model.ProductId);
            await productCollection.ReplaceOneAsync(filter, model, new ReplaceOptions { IsUpsert = true });
        }

        public async Task DeleteOneAsync(int id)
        {
            var productCollection = ConnectToMongo<ProductModel>(_productCollection);
            await productCollection.DeleteOneAsync(m => m.ProductId == id);
        }

        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(_connectionString);
            var db = client.GetDatabase(_databaseName);
            return db.GetCollection<T>(collection);
        }
    }
}
