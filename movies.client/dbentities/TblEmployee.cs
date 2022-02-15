using System;
using System.Collections.Generic;

namespace movies.client.dbentities
{
    public partial class TblEmployee
    {
        public int EmployeId { get; set; }
        public string EmployeeNmae { get; set; }
        public string EmployeeDep { get; set; }
        public int EmployeeSalary { get; set; }
        public DateTime? EmployeeJoiningDate { get; set; }
    }
}
