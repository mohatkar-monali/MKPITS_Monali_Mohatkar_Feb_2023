using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookYourTicket
{
    //creating static class
    public static class BookTicket
    {
        //creating static variable sqlconnection
        private static string sqlconnection = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=BookMyShow;";
        //creating static method 
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection con=new SqlConnection(sqlconnection);
            try { con.Open();
                return con;
            }
            catch { return null; }
            //finally { con.Close(); }
          
        }
        //create static method to fill theatername
        public static DataSet GetTheaterName()
        {
            SqlConnection con=GetSqlConnection();
            string query = "select * from Theater";
            DataSet ds = new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query,con);
            da.Fill(ds,"TheaterName");
            return ds;
        }
        //creating static method to fill moviename
        public static DataSet GetMovieName(string theatername) 
        {
            SqlConnection con=GetSqlConnection();
            string query = "select m.movie_name from movie m inner join theater t on m.mid=t.theaterid where theatername=@theatername;";
            DataSet ds= new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query,con);   
            da.SelectCommand.Parameters.AddWithValue("@theatername",theatername);
            da.Fill(ds,"movie");
            return ds;
        }
        //creating static method to fill showtime
        public static DataSet GetShowTime(string movie_name)
        {
            SqlConnection con=GetSqlConnection();
            string query = "select show_time from movie where Movie_Name=@movie_name";
            DataSet ds= new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("movie_name", movie_name);
            da.Fill(ds, "movie");
            return ds;
        }
        //createing static method to fill price
        public static DataSet GetPrice(string movie_name)
        {
            SqlConnection con=GetSqlConnection();
            string query = "select price from movie where Movie_Name=@Movie_Name";
            DataSet ds= new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(query,con);
            da.SelectCommand.Parameters.AddWithValue("@movie_name", movie_name);
            da.Fill(ds, "movie");
            return ds;
        }
        public static string InsertBookingDetails(string Name, string ContactNo, string Gender, string TheaterName, string MovieName, string ShowTime, int No_Of_Seat, int Price, DateTime date)
        {
            SqlConnection con = GetSqlConnection();
            //creating a insert command
            string query = "insert into BookingDetails values(@Name,@ContactNo,@Gender,@TheaterName,@MovieName,@ShowTime,@No_Of_Seat,@Price,@Date)";
            //@username and @password are sqlparameters
            string result = null;

      
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters

                command.Parameters.AddWithValue("@name", Name);
                command.Parameters.AddWithValue("@ContactNo", ContactNo);
                command.Parameters.AddWithValue("@Gender", Gender);
                command.Parameters.AddWithValue("@TheaterName", TheaterName);
                command.Parameters.AddWithValue("MovieName", MovieName);
                command.Parameters.AddWithValue("@ShowTime", ShowTime);
                command.Parameters.AddWithValue("@No_Of_Seat", No_Of_Seat);
                command.Parameters.AddWithValue("@Price", Price);
                command.Parameters.AddWithValue("@Date", date);
            try 
            {  
              //executing the command using executenonquery method
                command.ExecuteNonQuery();
                result = "saved successfully";
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            finally { con.Close(); }
            return result;

        }
    }

}
