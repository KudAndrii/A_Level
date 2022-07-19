using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switcher.Configs
{
    using Newtonsoft.Json;
    public class Config
    {
        [JsonProperty("MongoConfig")]
        public MongoConfig MongoDbData { get; set; }
    }
}
