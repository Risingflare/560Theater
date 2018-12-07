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
    public delegate void RemoveTicketHistoryDel(int index);
    public delegate void LoadTicketHistory();
    public delegate void BuyTicketDel(int showingID);
    public delegate void ListViewTicketHistory(string name);
    class Form1Controller
    {        
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;
        List<ListBoxTheaterMovie> movies;
        List<ListBoxTheaterMovie> theaters;
        List<string> movienames;
        List<string> theaternames;
        List<string> theaterLocation;
        int customerID;
        public Form1Controller(int userId)
        {
            connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False");
            cmd = new SqlCommand();
            movies = new List<ListBoxTheaterMovie>();
            theaters = new List<ListBoxTheaterMovie>();
            movienames = new List<string>();
            theaternames = new List<string>();
            theaterLocation = new List<string>();
            customerID = GetCustomerId(userId);
            if (customerID == -1) throw new Exception("There was trouble in getting the correct customer");
        }
        /// <summary>
        /// I think this gets the procedure information from the database.
        /// </summary>
        public void GetMovieList()
        {
            string moviename = "";
            cmd.Parameters.Clear();
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.GetMovies";//This is getting the movie list procedure
            cmd.Connection = connection;
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader["MovieName"].ToString();
                    bool b = (bool)reader["Active"];
                    if (b)
                    {
                        movienames.Add(name);
                        moviename = moviename + name + "\n";
                    }
                }
            }
            connection.Close();
            
            foreach (ListBoxTheaterMovie movie in movies)
            {
                movie(moviename);
            }
        }
        /// <summary>
        /// It works but I need more research on the topic, will come back with better code or answer.
        /// </summary>
        /// <param name="movie"></param>
        public void UpdateMovies(ListBoxTheaterMovie movie)
        {
            movies.Add(movie);
        }
        public void GetTheaterList()
        {
            string theatername = "";
            cmd.Parameters.Clear();
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.GetTheaters";//This is getting the theater list procedure
            cmd.Connection = connection;
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader["TheaterName"].ToString();
                    string location = reader["Location"].ToString();
                    bool b = (bool)reader["Active"];
                    if(b)
                    {
                        theaterLocation.Add(location);
                        theaternames.Add(name);
                        theatername = theatername + name + "\n";
                    }
                }
            }
            connection.Close();
            foreach (ListBoxTheaterMovie theater in theaters)
            {
                theater(theatername);
            }
        }
        /// <summary>
        /// It works but I need more research on the topic
        /// </summary>
        /// <param name="theater"></param>
        public void UpdateTheater(ListBoxTheaterMovie theater)
        {
            theaters.Add(theater);
        }
        /// <summary>
        /// Method that handles the history option click
        /// It creates a new form and a controller to take care of any actions within that form
        /// </summary>
        public void History()
        {
            HistoryGUIController controller = new HistoryGUIController(connection,cmd,reader,customerID);
            HistoryGUI gui = new HistoryGUI(controller.HistoryRemoveTicket, controller.GetTickets);
            controller.UpdateTicketForm(gui.UpdateTicketListView);
            
            gui.Show();
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
            ShowTimeController controller = new ShowTimeController(connection, cmd, reader, customerID);
            ShowTimeGUI gui = new ShowTimeGUI(connection, cmd, reader,moviename,theatername,time, controller.BuyTicket);
            gui.Show();
        }
        
        private int GetCustomerId(int userId)
        {
            int customerID = -1;
            cmd.Parameters.Clear();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.GetCustomerID";//This is getting the theater list procedure
            cmd.Connection = connection;

            SqlParameter userIdparam = new SqlParameter();
            userIdparam.ParameterName = "@UserId";
            userIdparam.SqlDbType = System.Data.SqlDbType.Int;
            userIdparam.Direction = System.Data.ParameterDirection.Input;
            userIdparam.Value = userId;

            cmd.Parameters.Add(userIdparam);
            connection.Open();
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                     customerID = Convert.ToInt32(reader["CustomerId"]);
                }
            }
            connection.Close();
            return customerID;
        }
    }
}
