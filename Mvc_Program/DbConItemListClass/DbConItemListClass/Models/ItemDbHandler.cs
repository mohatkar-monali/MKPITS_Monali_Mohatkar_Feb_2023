using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DbConItemListClass.Models
{
    public class ItemDbHandler
    {
        SqlConnection con = null;
        public void Connection()
        {
           // string conquery = ConfigurationManager.ConnectionStrings["ConItemDb"].ToString();
            string constr = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=ConItemDb"; 
            con = new SqlConnection(constr);
        }

        public bool InsertItem(ItemModel itm)
        {
            Connection();
            string query = "Insert into ItemTable values('" + itm.Name + "','" + itm.Category + "','" + itm.Price + "')";
            SqlCommand cmd =new SqlCommand(query,con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i>=1 )
            {   
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ItemModel> GetItems()
        {
            Connection();
            List<ItemModel> list = new List<ItemModel>();
            string query = "select * from itemtable";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter ad=new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            con.Open();
            ad.Fill(dt);
            con.Close() ;
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new ItemModel
                {
                    Id = Convert.ToInt32(dr["id"]),
                    Name = Convert.ToString(dr["name"]),
                    Category = Convert.ToString(dr["category"]),
                    Price = Convert.ToInt32(dr["Price"])
                });
            
            }
            return list;
        }

        public bool UpdateItem(ItemModel imt)
        {
            Connection();
            string query = "update itemtable set Name='" + imt.Name + "',Category='" + imt.Category + "',price='" + imt.Price + "'";
            SqlCommand cmd=new SqlCommand(query, con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i >= 1) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteItem(ItemModel imt)
        {
            Connection();
            string query="delete from itemtable where id='"+imt.Id+"'";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if(i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}