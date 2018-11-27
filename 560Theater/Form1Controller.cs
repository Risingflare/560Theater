﻿using System;
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
            test = new List<string>();
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
                    moviename = moviename + reader["MovieName"].ToString() + "\n";
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
                    theatername = theatername + reader["TheaterName"].ToString() + "\n";
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
    }
}
