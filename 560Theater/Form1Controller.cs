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
        List<string> _movieList;
        List<Ticket> _ticketList;
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;
        public Form1Controller()
        {
            connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False");
            cmd = new SqlCommand();
        }
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
            HistoryGUI gui = new HistoryGUI(this.HistoryRemoveTicket);
            gui.Show();
        }
        /// <summary>
        /// I think this gets the procedure information from the database.
        /// </summary>
        private void GetMovieList()
        {
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "StoredProcedureName";
            cmd.Connection = connection;
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string moviename = reader["MovieName"].ToString();
                    _movieList.Add(moviename);
                }
            }
            connection.Close();
        }
        /// <summary>
        /// This code needs some updates but I need to see the procedure so I can execute it correctly.
        /// </summary>
        private void HistoryGetTicketList()
        {
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "StoredProcedureName";
            cmd.Connection = connection;
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string moviename = reader["MovieName"].ToString();
                    string theatername = reader["TheaterName"].ToString();
                    DateTime showtime = Convert.ToDateTime(reader["ShowTime"]);
                    int room = Convert.ToInt32(reader["Room"]);
                    Ticket ticket = new Ticket(moviename, theatername, showtime, room);
                    _ticketList.Add(ticket);
                }
            }
            connection.Close();
        }
        /// <summary>
        /// This will execute the Remove History Procedure.
        /// </summary>
        /// <param name="ticket"></param>
        private void HistoryRemoveTicket(string ticket)
        {
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "StoredProcedureName";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@ticket", ticket);

        }
    }
}
