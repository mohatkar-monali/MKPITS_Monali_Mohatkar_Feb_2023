using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace fendhalproject
{
    //create static class
    public static class ProductStore
    {

        //create static variable
        private static string connection = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=Fendhal;";
       
        //create static method
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection con = new SqlConnection(connection);
            try
            {
                con.Open();
                return con;
            }
            catch
            {
                return null;
            }
            finally
            {
                //con.Close(); 
            }
        }
        public static DataSet Gettableproductcategory()
        {
            SqlConnection conn = GetSqlConnection();
            string query = "select * from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "Product_type_Name");
            return ds;
        }
        public static DataSet Gettableproductname(string product_type_name)
        {
            SqlConnection con = GetSqlConnection();
            string query = "select p.Product_Id, p.product_Name from TableProduct p inner join TableProductCategory t on p.ProductTypeID = t.Product_Category_ID   where t.Product_Type_Name = @product_type_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            da.Fill(ds, "tableproduct");
            return ds;

        }
        //method to return gstdetails for given product name
        public static DataSet GetGstDetails(string product_type_name)
        {
            SqlConnection con = GetSqlConnection();
            string query = "select a.cgst,a.sgst,a.igst from TableProductGstDetails a inner join tableproductcategory b on a.Product_Gst_Id=b.Product_Gst_id where b.Product_type_Name=@product_type_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            da.Fill(ds, "tableproductcategorry");
            return ds;
        }
        public static DataSet GetProductPrice(string Product_Name)
        {
            SqlConnection con = GetSqlConnection();
            string query = "select price from tableproduct where Product_Name=@Product_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_name", Product_Name);
            da.Fill(ds, "tableproduct");
            return ds;

        }
        public static string SaveTableInvoiceDetails(string customer_name, long customer_contact, int product_category_id, int product_id, int residential_type_id, DateTime invoice_date, decimal quantity, decimal price, decimal cgst, decimal sgst, decimal igst, decimal cgst_value, decimal sgst_value, decimal igst_value, decimal total_amount)
        {
            SqlConnection con = GetSqlConnection();
            string query = "insert into TableInvoiceDetails values(@customername,@customercontact,@productcategoryid,@productid,@residentialtypeid,@invoicedate,@quantity,@price,@cgst,@sgst,@igst,@cgstvalue,@sgstvalue,@igstvalue,@totalamount)";
            string result = null;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@customername", customer_name);
            cmd.Parameters.AddWithValue("@customercontact", customer_contact);
            cmd.Parameters.AddWithValue("@productcategoryid", product_category_id);
            cmd.Parameters.AddWithValue("@productid", product_id);
            cmd.Parameters.AddWithValue("@residentialtypeid", residential_type_id);
            cmd.Parameters.AddWithValue("@invoicedate", invoice_date);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@cgst", cgst);
            cmd.Parameters.AddWithValue("@sgst", sgst);
            cmd.Parameters.AddWithValue("@igst", igst);
            cmd.Parameters.AddWithValue("@cgstvalue", cgst_value);
            cmd.Parameters.AddWithValue("@sgstvalue", sgst_value);
            cmd.Parameters.AddWithValue("@igstvalue", igst_value);
            cmd.Parameters.AddWithValue("@totalamount", total_amount);
            try
            {
                cmd.ExecuteNonQuery();
                return "record saved successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally { con.Close(); }
            return result;

        }
    }

}
