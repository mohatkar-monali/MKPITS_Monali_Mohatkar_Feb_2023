using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Fendhal
{
    public static class ProductStore
    {
        private static string connection = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=fendhal;";
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex) 
            {
                return null;
            }

        }
        public static DataSet GetProductCategoryId()
        {
            SqlConnection con= GetSqlConnection();
            string query = "select * from TableProductCategory";
            DataSet ds=new DataSet();
            SqlDataAdapter dr = new SqlDataAdapter(query, con);
            dr.Fill(ds,"Product_type_Name");
            return ds;
        }
        public static DataSet Getproductname(string product_type_name) 
        {
            SqlConnection con= GetSqlConnection();
            string query = "select p.Product_Id,p.Product_Name from tableproduct p inner join  tableproductcategory  t on p.ProductTypeId=t.Product_Category_Id where Product_type_Name=@producttypename";
            DataSet ds=new DataSet();
            SqlDataAdapter dr = new SqlDataAdapter( query, con);
            dr.SelectCommand.Parameters.AddWithValue("@producttypename", product_type_name);
            dr.Fill(ds, "tableproductcategory ");
            return ds;
        }
        public static DataSet  Getgstdetails(string product_type_name)
        {
            SqlConnection con= GetSqlConnection();
            string query = "select a.cgst,a.sgst,a.igst from tableproductgstdetails a inner join tableproductcategory b on a.Product_Gst_Id=b.Product_Gst_id where @product_type_name=product_type_name";
            DataSet ds=new DataSet();
            SqlDataAdapter dr = new SqlDataAdapter(query, con);
            dr.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            dr.Fill(ds, "tableproductgstdetails");
            return ds;
            
        }public static DataSet GetPrice(string Product_Name)
        {
            SqlConnection con=new SqlConnection();
            string query="select price from tableproduct where productname="
        }
    }
}
