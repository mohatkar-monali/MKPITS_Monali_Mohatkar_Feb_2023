using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
namespace ItemDbConncetion.Models
{
    public class ItemDbHandler
    {
        SqlConnection con = null;

        public void Conncetion()
        {
            string constr = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=ConItemDb";
            con = new SqlConnection(constr);
        }

        // creating InsertItem method to insert record into itemtable
        public bool InsertItem(ItemModel itm)
        {
            Conncetion();
            string query = "Insert into ItemTable values('" + itm.Name + "','" + itm.category + "','" + itm.price + "')";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            int i=cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
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
