using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _560Theater
{
    /// <summary>
    /// This class will be the controller in our MVC interface.
    /// It will use procedures to execute any requests to the database.
    /// </summary>
    class Controller
    {
        /// <summary>
        /// The list of movies
        /// </summary>
        List<string> movieList;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="moviename"></param>
        /// <param name="theatername"></param>
        /// <param name="time"></param>
        public void Showtimes(string moviename,string theatername,string time)
        {
            ShowTimeGUI gui = new ShowTimeGUI();
            gui.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        public void History()
        {
            HistoryGUI gui = new HistoryGUI();
            gui.Show();
        }
        /// <summary>
        /// I think this gets the procedure information from the database.
        /// </summary>
        private void GetMovieList()
        {
            SqlConnection connection = new SqlConnection(/* Our connection string */);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "StoredProcedureName";
            cmd.Connection = connection;
            SqlDataReader reader;

            connection.Open();
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    movieList.Add(reader["MovieName"].ToString());
                }
            }                       
        }
    }
}
