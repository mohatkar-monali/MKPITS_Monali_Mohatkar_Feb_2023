using CrudwithAjax.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace CrudwithAjax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private SqlConnection con;
        public void Connection()
        {
            string constr = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=EmployeeDb";
            con = new SqlConnection(constr);
        }
        
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(EmpModel emp)
        {
            AddDetails(emp);
            return View();
        }
        public void AddDetails(EmpModel emp)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("AddEmp",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", emp.Name);
            cmd.Parameters.AddWithValue("@Address", emp.Address);
            cmd.Parameters.AddWithValue("@City",emp.City);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        [HttpPost]
        public ActionResult UpdateEmployee(EmpModel emp)
        {
            AddDetails(emp);
            return View();
        }
        public void UpdateDetails(EmpModel emp)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("UpdateEmp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", emp.Name);
            cmd.Parameters.AddWithValue("@Address", emp.Address);
            cmd.Parameters.AddWithValue("@City", emp.City);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        [HttpPost]
        public ActionResult DeleteEmployee(EmpModel emp)
        {
            DeleteDetails(emp);
            return View();
        }

        public void DeleteDetails(EmpModel emp)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("DeleteEmp", con);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", emp.Name);
            cmd.Parameters.AddWithValue("@Address", emp.Address);
            cmd.Parameters.AddWithValue("@City", emp.City);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}  