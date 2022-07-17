using System;
using System.Collections.Generic;

namespace LazyLoadingDb.Models
{
    public partial class Title
    {
        public Title()
        {
            Employees = new HashSet<Employee>();
        }

        public int TitleId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
