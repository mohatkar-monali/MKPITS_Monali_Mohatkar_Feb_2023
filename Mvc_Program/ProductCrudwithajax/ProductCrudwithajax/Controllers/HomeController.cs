using ProductCrudwithajax.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace ProductCrudwithajax.Controllers
{
    public class HomeController : Controller
    {
        private SqlConnection con;
        public void Connection()
        {
            string ConStr = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=EmployeeDb";
            con = new SqlConnection(ConStr);
        }
        // GET: Home
        public ActionResult Product()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult Product(ProductModel pm)
        {
            InsertProduct(pm);
            return View();
        }

        public void InsertProduct(ProductModel pm)
        {
            Connection();
            //string query = "insert into product values(@ProdName,@Category,@Quantity,@Price)";
            SqlCommand cmd =new SqlCommand("AddProduct",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProdName", pm.ProdName);
            cmd.Parameters.AddWithValue("@Category", pm.Category);
            cmd.Parameters.AddWithValue("@Quantity", pm.Quantity);
            cmd.Parameters.AddWithValue("@Price", pm.price);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}