﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpDbConProject.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }

        public int Sallary { get; set; }
        public string Address { get; set; }
    }
}