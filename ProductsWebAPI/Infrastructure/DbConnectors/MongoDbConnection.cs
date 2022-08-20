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

        public async Task<ProductModel> GetById(int id)
        {
            var productCollection = ConnectToMongo<ProductModel>(_productCollection);
            var result = await productCollection.FindAsync(x => x.ProductId == id);
            if (result is null)
            {
                throw new ArgumentNullException();
            }

            return result as ProductModel;
        }

        public Task InsertOne(ProductModel model)
        {
            var productCollection = ConnectToMongo<ProductModel>(_productCollection);
            return productCollection.InsertOneAsync(model);
        }

        public Task UpdateOne(ProductModel model)
        {
            var productCollection = ConnectToMongo<ProductModel>(_productCollection);
            var filter = Builders<ProductModel>.Filter.Eq("ProductId", model.ProductId);
            return productCollection.ReplaceOneAsync(filter, model, new ReplaceOptions { IsUpsert = true });
        }

        public Task DeleteOne(ProductModel model)
        {
            var productCollection = ConnectToMongo<ProductModel>(_productCollection);
            return productCollection.DeleteOneAsync(m => m.ProductId == model.ProductId);
        }

        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(_connectionString);
            var db = client.GetDatabase(_databaseName);
            return db.GetCollection<T>(collection);
        }
    }
}
