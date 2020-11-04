using System;
using System.Collections.Generic;

#nullable disable

namespace DimensionData.Models
{
    public partial class EmployeeDetail
    {
        public int EmployeeDetailsId { get; set; }
        public int? Age { get; set; }
        public string Attrition { get; set; }
        public string DistanceFromHome { get; set; }
        public int? EmployeeNumber { get; set; }
        public string Over18 { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public int? JobInfoId { get; set; }
        public int? SalaryId { get; set; }
        public int? EmpHistoryId { get; set; }
        public int? SurveyId { get; set; }
        public int? EducationId { get; set; }
        public int? PerfomanceId { get; set; }
    }
}
