using System;
using System.Collections.Generic;

namespace LazyLoadingDb.Models
{
    public partial class Office
    {
        public Office()
        {
            Employees = new HashSet<Employee>();
        }

        public int OfficeId { get; set; }
        public string Title { get; set; } = null!;
        public string Location { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
