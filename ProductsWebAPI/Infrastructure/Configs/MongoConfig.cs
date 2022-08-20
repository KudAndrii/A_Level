using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configs
{
    public class MongoConfig
    {
        public string ConnectionString { get; set; }
        public string DbName { get; set; }
    }
}
