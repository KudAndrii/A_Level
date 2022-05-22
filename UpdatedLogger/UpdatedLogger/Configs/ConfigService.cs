using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using UpdatedLogger.Interfaces;
using Newtonsoft.Json;

namespace UpdatedLogger.Configs
{
    internal class ConfigService : IConfigService
    {
        public string GetPath()
        {
            var configFile = File.ReadAllText(@"..\..\..\Configs\config.json");

            // var path = JsonConvert.DeserializeObject<string>(configFile);
            // return "..\\..\\..\\Logs\\";
            return JsonConvert.DeserializeObject<string>(configFile);
        }
    }
}
