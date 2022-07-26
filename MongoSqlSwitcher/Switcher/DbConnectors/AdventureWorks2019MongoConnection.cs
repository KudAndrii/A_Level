using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Switcher.Models;
using Switcher.Interfaces;
using Switcher.Services;

namespace Switcher.DbConnectors
{
    using Switcher.Models.CustomModels;
    internal class AdventureWorks2019MongoConnection
    {
        private const string _userCollection = "User";
        private readonly string _connectionString;
        private readonly string _databaseName;
        public AdventureWorks2019MongoConnection()
        {
            IConfigService configService = new ConfigService();
            _connectionString = configService.MongoDbInfo.ConnectionString;
            _databaseName = configService.MongoDbInfo.DbName;

        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            var users = ConnectionToCollection<User>(_userCollection);
            var result = await users.FindAsync(_ => true);
            return result.ToList();
        }

        public Task CreateUser(User user)
        {
            var users = ConnectionToCollection<User>(_userCollection);
            return users.InsertOneAsync(user);
        }

        public Task UpdateUser(User user)
        {
            var users = ConnectionToCollection<User>(_userCollection);
            var filter = Builders<User>.Filter.Eq("Id", user.Id);
            return users.ReplaceOneAsync(filter, user, new ReplaceOptions { IsUpsert = true });
        }

        public Task DeleteUserAsync(User user)
        {
            var users = ConnectionToCollection<User>(_userCollection);
            return users.DeleteOneAsync(u => u.Id == user.Id);
        }

        public Task DeleteAllUsersAsync()
        {
            var userCollection = ConnectionToCollection<User>(_userCollection);
            return userCollection.DeleteManyAsync(_ => true);
        }

        /// <summary>
        /// Method sets new collection for Database.
        /// </summary>
        /// <typeparam name="TCollection">Type of entity.</typeparam>
        /// <param name="nameOfCollection">Name of collection.</param>
        /// <returns>New collection for Mongo Database.</returns>
        private IMongoCollection<TCollection> ConnectionToCollection<TCollection>(in string nameOfCollection)
        {
            var client = new MongoClient(_connectionString);
            var db = client.GetDatabase(_databaseName);
            return db.GetCollection<TCollection>(nameOfCollection);
        }
    }
}
