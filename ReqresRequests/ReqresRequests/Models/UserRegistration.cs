using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresRequests.Models
{
    using Newtonsoft.Json;
    public class UserRegistration
    {
        public UserRegistration(string email, string password)
        {
            Email = email;
            Password = password;
        }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
