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
        public uxCustomerUI(ShowShowtimeDel showdel, ShowHistoryDel histdel)
        {
            showShowtimeHandler = showdel;
            showHistoryHandler = histdel;
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
            if(uxTheaterListBox.SelectedItem != null) theatername = uxTheaterListBox.SelectedItem.ToString();
            string showtime = uxHoursNumeric.ToString() + uxMinutesNumeric.ToString();
            showShowtimeHandler(moviename, theatername, showtime);
        }
    }
}
