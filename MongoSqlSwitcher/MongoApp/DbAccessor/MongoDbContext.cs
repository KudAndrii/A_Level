using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoApp.Models;

namespace MongoApp.DbAccessor
{
    internal class MongoDbContext
    {
        private const string _connectionString = "mongodb://127.0.0.1:27017";
        private const string _dbName = "DbApp";
        private const string _usersCollection = "Users";

        public MongoDbContext()
        {
            var client = new MongoClient(_connectionString);
            var db = client.GetDatabase(_dbName);
            Users = db.GetCollection<User>(_usersCollection);
        }

        public IMongoCollection<User> Users { get; }
    }
}
