using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmpDbConProject.Models
{
    public class EmpDbHandler
    {
        SqlConnection con=null;

        public void Connection()
        {
            string constr = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=ConItemDb";
            con=new SqlConnection(constr);
        }

        public  bool InsertEmployee(EmployeeModel emp)
        {
            Connection();
            string query = "Insert into employeeetable values('" + emp.EmpName + "','" + emp.Designation + "','" + emp.Sallary + "','" + emp.Address + "')";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i >= 1)
            {
                return true;
            }
            else { return false; }
        }
    }
}