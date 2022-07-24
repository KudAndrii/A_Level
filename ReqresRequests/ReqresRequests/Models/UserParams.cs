using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresRequests.Models
{
    using Newtonsoft.Json;
    public class UserParams
    {
        public UserParams(string name, string job)
        {
            Name = name;
            Job = job;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }
    }
}
