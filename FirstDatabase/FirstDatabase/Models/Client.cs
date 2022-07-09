using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDatabase.Models
{
    [Table(nameof(Client))]
    internal class Client
    {
        public int ClientId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
