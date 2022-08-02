using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWAndRepositoryWithMongoAndSql.Configs
{
    using Newtonsoft.Json;
    public class Config
    {
        [JsonProperty("MonfoConfig")]
        public MongoConfig Mongo { get; set; }
    }
}
