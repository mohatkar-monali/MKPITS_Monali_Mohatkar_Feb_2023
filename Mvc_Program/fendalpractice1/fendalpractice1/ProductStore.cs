using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace fendalpractice1
{
     public static class ProductStore
     {
        //creating a  static a vriable
        private static string Conncetion = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=Fendhal";

        public static SqlConnection GetConnection()
        {
            SqlConnection con= new SqlConnection(Conncetion);
            try
            {
                con.Open();
                return con;
            }
            catch(Exception ee)
            {
                return null; 
            }
        }

        public static DataSet GetProductcategory()
        {
            SqlConnection con= GetConnection();
            string query = "select * from tableproductcategory";
            DataSet ds=new DataSet();
            SqlDataAdapter da=new SqlDataAdapter(query,con);
            da.Fill(ds,"Product_type_Name");
            return ds;
        }

        public  static DataSet GetProductName(string product_type_name)
        {
            SqlConnection con = GetConnection();
            string query = "select t.Product_Id ,t.Product_Name from TableProduct t inner join TableProductCategory c on t.ProductTypeId=c.Product_Category_Id where c.Product_type_name=@Product_type_name";
            DataSet ds=new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("Product_type_name", product_type_name);
            da.Fill(ds,"tableproduct");
            return ds;
        }

        public static DataSet GetProductPrice(string product_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select price from tableproduct where product_Name=@Product_Name";
            DataSet ds=new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Name", product_Name);
            da.Fill(ds, "Price");
            return ds;
        }

        public static DataSet GetGstDetails(string product_type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select a.cgst,a.sgst,a.igst from Tableproductgstdetails a inner join tableproductcategory b on b.product_gst_id=a.product_gst_id where product_type_name=@product_type_name";
            DataSet ds=new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.SelectCommand.Parameters.AddWithValue("product_type_name", product_type_Name);
            da.Fill(ds, "tableproductcategory");
            return ds;
        }


     }
}
