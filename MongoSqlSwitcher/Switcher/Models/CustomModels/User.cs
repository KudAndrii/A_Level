using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switcher.Models.CustomModels
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }

        public User Child { get; set; }

    }
}
