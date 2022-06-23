using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using ModuleTaskThree.Configs;
using ModuleTaskThree.Abstractions;

namespace ModuleTaskThree.Services
{
    internal class ConfigService : IConfigService
    {
        private const string _configPath = "..\\..\\..\\Config.json";
        private readonly Config _config;
        public ConfigService()
        {
            _config = GetConfigInfo();
            BackupConfig = _config.BackupConfig;
            LoggerConfig = _config.LoggerConfig;
        }

        public BackupConfig BackupConfig { get; }
        public LoggerConfig LoggerConfig { get; }

        /// <summary>
        /// Method gets info from _configPath file.
        /// </summary>
        /// <returns>Example of class Config with full info.</returns>
        private Config GetConfigInfo()
        {
            var configFile = File.ReadAllText(_configPath);
            return JsonConvert.DeserializeObject<Config>(configFile);
        }
    }
}
