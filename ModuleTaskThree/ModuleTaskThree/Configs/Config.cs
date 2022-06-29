using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModuleTaskThree.Configs
{
    internal class Config
    {
        [JsonProperty(PropertyName = "BackupFrequency")]
        public BackupConfig BackupConfig { get; set; }
        [JsonProperty(PropertyName ="LoggerInfo")]
        public LoggerConfig LoggerConfig { get; set; }
    }
}
