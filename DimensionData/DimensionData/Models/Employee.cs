using System;
using System.Collections.Generic;

#nullable disable

namespace DimensionData.Models
{
    public partial class Employee
    {
        public int EmployeeNumber { get; set; }
        public string Name { get; set; }
        public int? EmployeeDetailsId { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}
