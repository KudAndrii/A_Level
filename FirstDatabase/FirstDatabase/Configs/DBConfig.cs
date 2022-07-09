using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FirstDatabase.Configs
{
    internal class DBConfig
    {
        [JsonProperty(PropertyName = "ConnectionStringToLocalDB")]
        public string? ConnectionString { get; set; }
    }
}
