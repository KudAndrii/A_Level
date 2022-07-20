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
    internal class AdventureWorks2019MongoConnection
    {
        private readonly string _connectionString;
        private readonly string _databaseName;
        public AdventureWorks2019MongoConnection()
        {
            IConfigService configService = new ConfigService();
            _connectionString = configService.MongoDbInfo.ConnectionString;
            _databaseName = configService.MongoDbInfo.DbName;

            var client = new MongoClient(_connectionString);
            var db = client.GetDatabase(_databaseName);
            Employees = db.GetCollection<Employee>(nameof(Employee));
        }

        public IMongoCollection<Employee> Employees { get; set; }
    }
}
