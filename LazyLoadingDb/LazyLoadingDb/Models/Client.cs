using System;
using System.Collections.Generic;

namespace LazyLoadingDb.Models
{
    public partial class Client
    {
        public int ClientId { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Age { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
