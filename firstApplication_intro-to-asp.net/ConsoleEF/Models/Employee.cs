using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEF.Models
{
    class Employee
    {
        // className + "Id" will be considered as primary key by EF
        public int EmployeeId { get; set; }
        //strings will be auto created as nvarchar(max) by default
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Designation { get; set; }

    }
}
