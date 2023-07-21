using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace fendalpractice2
{
    public static class ProductStore
    {
        private static string Connnection = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=Fendhal";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(Connnection);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            { return null; }


        }

        public static DataSet GetProductCategory()
        {
            SqlConnection con=new SqlConnection(Connnection);
            string query = "select * from tableproductcategory";
            SqlCommand cmd = new SqlCommand(query,con);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds,"producttypename");
            return ds;
        }

        public static DataSet GetProductName(string product_type_name)
        {
            SqlConnection con=GetConnection();
    
        }

    }
}
