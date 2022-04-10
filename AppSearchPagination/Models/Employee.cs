using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AppSearchPagination.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeStatus { get; set; }
        public decimal Salary { get; set; }
        public string PayBasis { get; set; }
        public string PositionTitle { get; set; }
    }
}
