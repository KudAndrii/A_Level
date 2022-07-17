using System;
using System.Collections.Generic;

namespace LazyLoadingDb.Models
{
    public partial class Project
    {
        public Project()
        {
            EmployeeProjects = new HashSet<EmployeeProject>();
        }

        public int ProjectId { get; set; }
        public string Name { get; set; } = null!;
        public decimal BudGet { get; set; }
        public DateTime StartedDate { get; set; }
        public int ClientId { get; set; }

        public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}
