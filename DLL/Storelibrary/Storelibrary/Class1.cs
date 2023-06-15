using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Storelibrary
{
    public class Dbconncetion
    {
        public static SqlConnection con;
        public static SqlConnection GetConnection()
        {
            con = new SqlConnection("server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=trust");
            con.Open();
            return con;
        }
    }
}
