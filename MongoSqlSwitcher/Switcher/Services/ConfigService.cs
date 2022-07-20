using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Switcher.Configs;
using Switcher.Interfaces;

namespace Switcher.Services
{
    public class ConfigService : IConfigService
    {
        private const string _configPath = @"C:\Users\cudan\Documents\GitHub\A_Level\MongoSqlSwitcher\Switcher\config.json";
        private readonly Config _config;
        public ConfigService()
        {
            _config = Deserialize();
            MongoDbInfo = _config.MongoDbData;
        }

        public MongoConfig MongoDbInfo { get; }

        private Config Deserialize()
        {
            var configFile = File.ReadAllText(_configPath);
            return JsonConvert.DeserializeObject<Config>(configFile);
        }
    }
}
