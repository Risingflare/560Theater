using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _560Theater
{
    public partial class uxCustomerUI : Form
    {
        /// <summary>
        /// Handler that takes care of the showtime click
        /// </summary>
        private ShowShowtimeDel showShowtimeHandler;
        /// <summary>
        /// Handler that takes care of the history click
        /// </summary>
        private ShowHistoryDel showHistoryHandler;
        private ShowMoviesDel showMoviesHandler;
        private ShowTheatersDel showTheaterHandler;
        uxLoginScreen loginScreen;
        public uxCustomerUI(ShowShowtimeDel showdel, ShowHistoryDel histdel, ShowMoviesDel moviesdel, ShowTheatersDel theatersDel,  uxLoginScreen loginScreen)
        {
            showShowtimeHandler = showdel;
            showHistoryHandler = histdel;
            showMoviesHandler = moviesdel;
            showTheaterHandler = theatersDel;
            this.loginScreen = loginScreen;
            InitializeComponent();
        }
        /// <summary>
        /// This will open a new form that will show the ticket history of the customer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxHistory_Click(object sender, EventArgs e)
        {
            showHistoryHandler();
        }
        /// <summary>
        /// This will open show time form using the attributes the customer selected. i.e. Movie Name, Theater, Showtime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSearch_Click(object sender, EventArgs e)
        {
            string moviename = "";
            if (uxMovieListBox.SelectedItem != null) moviename = uxMovieListBox.SelectedItem.ToString();
            string theatername = "";
            if (uxTheaterListBox.SelectedItem != null) theatername = uxTheaterListBox.SelectedItem.ToString();
            
            string showtime = "";
            if (uxHoursNumeric.Value == 0) showtime = "00:00:00";
            else
            {
                showtime = uxHoursNumeric.Value.ToString() + ":" + uxMinutesNumeric.Value.ToString() + ":00";
            }
            showShowtimeHandler(moviename, theatername, showtime);
            uxMovieListBox.SelectedItems.Clear();
            uxTheaterListBox.SelectedItems.Clear();
            uxHoursNumeric.Value = 00;
            uxMinutesNumeric.Value = 00;
        }
        /// <summary>
        /// Updates the movie list box
        /// </summary>
        /// <param name="movie"></param>
        public void UpdateMovie(string movie)
        {
            uxMovieListBox.Items.Clear();
            string[] substrings = movie.Split('\n');
            foreach(string m in substrings)
            {
                uxMovieListBox.Items.Add(m);
            }
            uxMovieListBox.Update();
        }
        /// <summary>
        /// Updates the theater list box
        /// </summary>
        /// <param name="theater"></param>
        public void UpdateTheater(string theater)
        {
            uxTheaterListBox.Items.Clear();
            string[] substrings = theater.Split('\n');
            foreach (string m in substrings)
            {
                uxTheaterListBox.Items.Add(m);
            }
            uxTheaterListBox.Update();
        }
        /// <summary>
        /// Shows the login screen when this form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCustomerUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginScreen.Show();
        }
        /// <summary>
        /// Populates the movie and theater list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCustomerUI_Load(object sender, EventArgs e)
        {
            showTheaterHandler();
            showMoviesHandler();
        }

    }
}
