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
    public delegate void RemoveTicketHistoryDel(string ticket);
    class Form1Controller
    {
        /// <summary>
        /// The list of movies
        /// </summary>
        List<string> movieList;
        /// <summary>
        /// Method creates a new Showtime form. It also initates another controller to handle any methods
        /// within that GUI.
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
        /// Method that handles the history option click
        /// It creates a new form and a controller to take care of any actions within that form
        /// </summary>
        public void History()
        {
            HistoryController controller = new HistoryController();
            HistoryGUI gui = new HistoryGUI(controller.RemoveTicket);
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
