using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FirstDatabase.Configs
{
    internal class Config
    {
        [JsonProperty(PropertyName = "DatabaseConfig")]
        public DBConfig? DBConfig { get; set; }
    }
}
