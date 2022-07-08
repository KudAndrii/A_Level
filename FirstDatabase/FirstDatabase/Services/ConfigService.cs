using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FirstDatabase.Configs;
using FirstDatabase.Interfaces;

namespace FirstDatabase.Services
{
    internal class ConfigService : IConfigService
    {
        private readonly string _configPath = "..\\..\\..\\Config.json";
        private readonly Config _config;
        public ConfigService()
        {
            _config = GetConfigInfo();
            DBConfig = _config.DBConfig;
        }

        public DBConfig DBConfig { get; }
        private Config GetConfigInfo()
        {
            var configFile = File.ReadAllText(_configPath);
            return JsonConvert.DeserializeObject<Config>(configFile);
        }
    }
}
