using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWAndRepositoryWithMongoAndSql.Interfaces
{
    using Configs;
    public interface IConfigService
    {
        public MongoConfig MongoInfo { get; }
        public Config GetConfigInfo();
    }
}
