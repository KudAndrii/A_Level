using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDatabase.Models
{
    [Table(nameof(Project))]
    internal class Project
    {
        public int ProjectId { get; set; }
        public string? Name { get; set; }
        public int BudGet { get; set; }
        public DateTime StartedDate { get; set; }
        public List<EmployeeProject> EmployeeProject { get; set; } = new List<EmployeeProject>();
    }
}
