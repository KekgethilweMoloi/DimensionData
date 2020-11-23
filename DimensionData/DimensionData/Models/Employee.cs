using System;
using System.Collections.Generic;

#nullable disable

namespace DimensionData.Models
{
    public partial class Employee
    {
        public int EmployeeNumber { get; set; }
        public string FullName { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public int? JobRole { get; set; }
        public string Department { get; set; }



    }
}
