using Infrastructure.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    using Infrastructure.Interfaces;
    using Newtonsoft.Json;
    public class ConfigService : IConfigService
    {
        private const string _configPath = @"..\config.json";
        public ConfigService()
        {
            Config config = Deserialize();
            MongoDbInfo = config.MongoDbData;
        }

        public MongoConfig MongoDbInfo { get; }

        private Config Deserialize()
        {
            var configFile = File.ReadAllText(_configPath);
            if (string.IsNullOrEmpty(configFile))
            {
                throw new DirectoryNotFoundException();
            }

            return JsonConvert.DeserializeObject<Config>(configFile);
        }
    }
}
