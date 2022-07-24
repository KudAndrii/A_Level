using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqresRequests.Models
{
    internal class User : UserParams
    {
        public int? Id { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
