﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApimvc.Models;
using WebApimvc.Models;

namespace WebApimvc.Controllers
{
    public class HomeController : ApiController
    {
        //creating an array of objects of employee class
        Employee[] employee = new Employee[]
        {
            new Employee{Id=1,Name="Mark",JoiningDate=DateTime.Parse(DateTime.Today.ToString()),Age=45},
            new Employee{Id=2,Name="John",JoiningDate=DateTime.Parse(DateTime.Today.ToString()),Age=34},
            new Employee{Id=3,Name="Shyam",JoiningDate= DateTime.Parse(DateTime.Today.ToString()),Age=43},
        };

        //creating a method getallemployees to return list of employees details
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            //employee is array of object created above
            return employee;
        }
    }
}
