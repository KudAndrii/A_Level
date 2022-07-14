using System;
using System.Collections.Generic;

namespace LazyLoadingDb.Models
{
    public partial class EmployeeProject
    {
        public int EmployeeProjectId { get; set; }
        public decimal Rate { get; set; }
        public DateTime StartedDate { get; set; }
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual Project Project { get; set; } = null!;
    }
}
