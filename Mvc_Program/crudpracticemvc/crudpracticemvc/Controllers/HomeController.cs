using crudpracticemvc.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudpracticemvc.Controllers
{
    public class HomeController : Controller
    {
        private SqlConnection con;
        
        public void Connection()
        {
            string constr = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=Employeedb";
            con = new SqlConnection(constr);
        }
        // GET: Home
         public ActionResult Index()
         {
            return View();
         }

        [HttpPost]
        public ActionResult Index(EmployeeModel em)
        {
            Addemployee(em);
            return View();
        }
         public void Addemployee(EmployeeModel em)
         {
            Connection();
            SqlCommand cmd = new SqlCommand("AddEmp", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Name", em.Name);
            cmd.Parameters.AddWithValue("Address", em.Address);
            cmd.Parameters.AddWithValue("City",em.City);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            

         }
    }
}