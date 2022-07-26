using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresRequests.Models
{
    using Newtonsoft.Json;
    internal class UserData
    {
        [JsonProperty("data")]
        public User User { get; set; }

        [JsonProperty("support")]
        public UserSupport UserSupport { get; set; }
    }
}
