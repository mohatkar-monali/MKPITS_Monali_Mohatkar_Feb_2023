using EmpDbConProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmpDbConProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet] 
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel empmd)
        {
            EmpDbHandler Handler = new EmpDbHandler();
            return View(Handler.InsertEmployee(empmd));
        }
    }
}