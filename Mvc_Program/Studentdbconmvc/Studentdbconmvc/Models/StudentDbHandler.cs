using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Studentdbconmvc.Models
{
    public class StudentDbHandler
    {
        SqlConnection con = null;
        public void Conncetion()
        {
            string constr = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=ConItemDb";
            con=new SqlConnection(constr);
        }

        public bool InsertStudent(StudentList st)
        {
            Conncetion();
            string qurey = "Insert into studenttable values('" + st.Name + "','" + st.Rollno + "','" + st.Email + "','" + st.MobileNo + "')";
            SqlCommand cmd = new SqlCommand(qurey,con);
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
        public bool UpdateStudent(StudentList st)
        {
            Conncetion();
            string query = "update studenttable SET name='" + st.Name + "',RollNo='" + st.Rollno + "',Email='" + st.Email + "',MobileNo='" + st.MobileNo + "' where studid= '"+st.StdId+"'";
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
        public List<StudentList> GetStudent()
        {
            Conncetion();
            List<StudentList> list=new List<StudentList>();
            string query = "select * from studenttable";
            SqlCommand cmd= new SqlCommand(query,con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt=new DataTable();
            con.Open();
            ad.Fill(dt);
            con.Close();
            foreach(DataRow dr in dt.Rows)
            {
                list.Add(new StudentList
                {
                    StdId = Convert.ToInt32(dr["StdId"]),
                    Name = Convert.ToString(dr["Name"]),
                    Rollno = Convert.ToInt32(dr["Rollno"]),
                    Email = Convert.ToString(dr["Email"]),
                    MobileNo = Convert.ToString(dr["MobileNo"])
                });
            }
            return list;

        }
    }
}