﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgt.HR.Employee.Dto
{
    public class GetAllEmployeeListDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public float BasicSalary { get; set; }
        public string Status { get; set; }
        public string Group { get; set; }
        public DateTime Description { get; set; }
    }
}
