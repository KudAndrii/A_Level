using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWAndRepositoryWithMongoAndSql.Services
{
    using Newtonsoft.Json;
    using Interfaces;
    using Configs;

    public class ConfigService : IConfigService
    {
        private const string _pathConfig = "config.json";
        public MongoConfig MongoInfo { get; }
        public ConfigService()
        {
            Config config = GetConfigInfo();
            MongoInfo = config.Mongo;
        }

        public Config GetConfigInfo()
        {
            var info = File.ReadAllText(_pathConfig);
            if (!string.IsNullOrEmpty(info))
            {
                return JsonConvert.DeserializeObject<Config>(info);
            }
            else
            {
                throw new DirectoryNotFoundException();
            }
        }
    }
}
