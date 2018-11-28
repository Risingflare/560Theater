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
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;
        List<ListBoxTheaterMovie> movies;
        List<ListBoxTheaterMovie> theaters;
        List<string> movienames;
        List<string> theaternames;
        List<string> theaterLocation;
        int customerID;
        /// <summary>
        /// A test string that I use to test my list boxes.
        /// </summary>
        List<string> test;
        public Form1Controller(int customerID)
        {
            connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False");
            cmd = new SqlCommand();
            this.customerID = customerID;
            movies = new List<ListBoxTheaterMovie>();
            theaters = new List<ListBoxTheaterMovie>();
            movienames = new List<string>();
            theaternames = new List<string>();
            theaterLocation = new List<string>();
        }
        /// <summary>
        /// I think this gets the procedure information from the database.
        /// </summary>
        public void GetMovieList()
        {
            string moviename = "";         
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.GetMovies";//This is getting the movie list procedure
            cmd.Connection = connection;
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader["MovieName"].ToString();
                    movienames.Add(name);
                    moviename = moviename + name + "\n";
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
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.GetTheaters";//This is getting the theater list procedure
            cmd.Connection = connection;
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string name = reader["TheaterName"].ToString();
                    theaterLocation.Add(reader["Location"].ToString());
                    theaternames.Add(name);
                    theatername = theatername + name + "\n";
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
            HistoryGUIController controller = new HistoryGUIController(connection,cmd,reader);
            HistoryGUI gui = new HistoryGUI(controller.HistoryRemoveTicket);
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
            ShowTimeController controller = new ShowTimeController(connection, cmd, reader);
            ShowTimeGUI gui = new ShowTimeGUI();
            gui.Show();
        }
        
        public void GenerateShowtimes()
        {
            string showtime = "";
            List<string> usedShowtimes = new List<string>();
            int[] hours = new int[] { 14, 15, 16, 17, 18, 19, 20 };
            int[] minutes = new int[] { 0, 15, 30, 45 };
            Random rn = new Random();
            for(int k = 0; k < theaternames.Count; k++)
            {
                usedShowtimes.Clear();
                int count = 0;
                while (count < 15)
                {
                    cmd.Parameters.Clear();
                    int i = rn.Next(0, 6);
                    int j = rn.Next(0, 3);
                    int room = rn.Next(1, 9);
                    int m = rn.Next(0, movienames.Count - 1);
                    int hour = hours[i];
                    int minute = minutes[j];
                    if (minute == 0)
                    {
                        showtime = hour.ToString() + ":00" + ":00";
                    }
                    else
                    {
                        showtime = hour.ToString() +":"+ minute.ToString() + ":00";
                    }
                    if (usedShowtimes.Contains(showtime)) continue;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.CreateShowing";//This is getting the theater list procedure
                    cmd.Connection = connection;

                    SqlParameter theatername = new SqlParameter();
                    theatername.ParameterName = "@TheaterName";
                    theatername.SqlDbType = System.Data.SqlDbType.NVarChar;
                    theatername.Direction = System.Data.ParameterDirection.Input;
                    theatername.Value = theaternames[k];

                    SqlParameter moviename = new SqlParameter();
                    moviename.ParameterName = "@MovieName";
                    moviename.SqlDbType = System.Data.SqlDbType.NVarChar;
                    moviename.Direction = System.Data.ParameterDirection.Input;
                    moviename.Value = movienames[m];

                    SqlParameter roomnum = new SqlParameter();
                    roomnum.ParameterName = "@Room";
                    roomnum.SqlDbType = System.Data.SqlDbType.Int;
                    roomnum.Direction = System.Data.ParameterDirection.Input;
                    roomnum.Value = room;

                    SqlParameter showtimeparam = new SqlParameter();
                    showtimeparam.ParameterName = "@ShowTime";
                    showtimeparam.SqlDbType = System.Data.SqlDbType.Time;
                    showtimeparam.Direction = System.Data.ParameterDirection.Input;
                    showtimeparam.Value = showtime;

                    SqlParameter location = new SqlParameter();
                    location.ParameterName = "@Location";
                    location.SqlDbType = System.Data.SqlDbType.NVarChar;
                    location.Direction = System.Data.ParameterDirection.Input;
                    location.Value = theaterLocation[k];

                    cmd.Parameters.Add(theatername);
                    cmd.Parameters.Add(moviename);
                    cmd.Parameters.Add(roomnum);
                    cmd.Parameters.Add(showtimeparam);
                    cmd.Parameters.Add(location);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    usedShowtimes.Add(showtime);
                    count++;
                }
            }
        }
    }
}
