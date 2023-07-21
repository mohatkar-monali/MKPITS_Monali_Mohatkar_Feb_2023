using mvcpracticecrud.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcpracticecrud.Controllers
{
    public class EmpController : Controller
    {
        private SqlConnection Con;
        public void Connection()
        {
            string Constr = "serevr=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=EmployeeDb";
            Con=new SqlConnection(Constr);    
        }
        // GET: Emp
        public ActionResult Index()
        {
            
            return View();
        }
        public  void AddDetails(Employee employee)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("AddEmp",Con);
            cmd.Parameters.AddWithValue("Name", employee.Name);
            cmd.Parameters.AddWithValue("Address", employee.Address);
            cmd.Parameters.AddWithValue("City", employee.City);
            Con.Open();
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        public ActionResult Addemp(Employee employee)
        {
            AddDetails(employee);
            return View();
        }
        
    }
}