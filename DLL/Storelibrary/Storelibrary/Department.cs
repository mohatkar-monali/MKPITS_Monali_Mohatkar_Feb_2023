using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Storelibrary
{

    public static  class Department
    {
        static SqlConnection con = Dbconncetion.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;

        //method to return department_id 
        public static string getDepartmentId()
        {
            string res = null;
            try
            {
                query = "select max(department_id) from department_master";
                cmd = new SqlCommand(query, con);
                con.Open();
                int vid = Convert.ToInt32(cmd.ExecuteScalar());

                res = vid.ToString();
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally
            {
                con.Close();

            }
            return res;
        }

        //method to insert record into department master
        public static string InsertDepartmentMaster(string department_name)
        {
            string res = null;
            try
            {
                query = "insert into department_master values(@department_name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@department_name", department_name);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "record inserted successfully";
            }
            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally { con.Close(); }
            return res;

        }
        //method to update record into department master
        public static string UpdateDepartmentMaster(string departmnt_name, int department_id)
        {
            string res = null;
            //code to check whether the departmentid exist or not
            query = "select count(*) from department_master where department_id=@department_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@department_id", department_id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (cnt > 0)
            {
                try
                {
                    query = "update department_master set department_name=@department_name where department_id=@department_id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@department_name", departmnt_name);
                    cmd.Parameters.AddWithValue("@department_id", department_id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    res = "record updated successfully";
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally { con.Close(); }

            }
            else
            {
                res = "no record exist";
            }
            return res;
        }
        //code to delete record from department master
        public static string DeleteDepartmentMaster(int department_id)
        {
            string res = null;
            //code to check whether the departmentid exist or not
            query = "select count(*) from department_master where department_id=@department_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@department_id", department_id);
              con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (cnt > 0)
            {
                try
                {
                    query = "delete from department_master where department_id=@department_id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@department_id", department_id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    res = "record deleted successfully";
                }
                catch (Exception ee)
                {
                    res = ee.ToString();
                }
                finally
                {
                    con.Close();
                }
                return res;
            }
            else
            {
                res = "no record exist";
            }
            return res;
        }
        //code to search record from department master
        public static DataSet SearchDepartmentMaster(int department_id)
        {
            
            query = "select * from department_master where department_id=@department_id";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@department_id", department_id);
            da.Fill(ds, "department_master");
            return ds;
        }
    }
}
