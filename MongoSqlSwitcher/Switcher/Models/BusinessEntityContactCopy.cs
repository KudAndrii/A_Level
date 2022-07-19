using System;
using System.Collections.Generic;

namespace Switcher.Models
{
    public partial class BusinessEntityContactCopy
    {
        public int BusinessEntityId { get; set; }
        public int PersonId { get; set; }
        public int ContactTypeId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
