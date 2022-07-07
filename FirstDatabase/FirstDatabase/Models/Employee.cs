﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDatabase.Models
{
    [Table(nameof(Employee))]
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime HiredDate { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int OfficeId { get; set; }
        public int TitleId { get; set; }
    }
}
