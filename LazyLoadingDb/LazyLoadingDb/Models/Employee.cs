using System;
using System.Collections.Generic;

namespace LazyLoadingDb.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeProjects = new HashSet<EmployeeProject>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public DateTime HiredDate { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int TitleId { get; set; }
        public int OfficeId { get; set; }

        public virtual Office Office { get; set; } = null!;
        public virtual Title Title { get; set; } = null!;
        public virtual ICollection<EmployeeProject> EmployeeProjects { get; set; }
    }
}
