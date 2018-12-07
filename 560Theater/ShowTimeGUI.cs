using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _560Theater
{
    public partial class ShowTimeGUI : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;
        BuyTicketDel buyticketHandler;
        
        public ShowTimeGUI(SqlConnection connection, SqlCommand cmd, SqlDataReader reader, string moviename, string theatername, string time, BuyTicketDel ticketDel)
        {
            InitializeComponent();
            this.connection = connection;
            this.cmd = cmd;
            this.reader = reader;
            buyticketHandler = ticketDel;
            UpdateShowtime(moviename, theatername, time);
        }

        private void UpdateShowtime(string moviename, string theatername, string time)
        {
            connection.Close();
            cmd.Parameters.Clear();
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.CustomerGetShowing";
            cmd.Connection = connection;

            SqlParameter theaternameparam = new SqlParameter();
            theaternameparam.ParameterName = "@TheaterName";
            theaternameparam.SqlDbType = System.Data.SqlDbType.NVarChar;
            theaternameparam.Direction = System.Data.ParameterDirection.Input;
            theaternameparam.Value = theatername;

            SqlParameter movieparam = new SqlParameter();
            movieparam.ParameterName = "@MovieName";
            movieparam.SqlDbType = System.Data.SqlDbType.NVarChar;
            movieparam.Direction = System.Data.ParameterDirection.Input;
            movieparam.Value = moviename;

            SqlParameter timeparam = new SqlParameter();
            timeparam.ParameterName = "@ShowTime";
            timeparam.SqlDbType = System.Data.SqlDbType.NVarChar;
            timeparam.Direction = System.Data.ParameterDirection.Input;
            timeparam.Value = time;

            cmd.Parameters.Add(theaternameparam);
            cmd.Parameters.Add(movieparam);
            cmd.Parameters.Add(timeparam);
            int row = 0;
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    bool b = (bool)reader["Active"];
                    if (b)
                    {
                        ListViewItem item = new ListViewItem(reader["MovieName"].ToString(), row);
                        item.SubItems.Add(reader["TheaterName"].ToString());
                        item.SubItems.Add(reader["Location"].ToString());
                        item.SubItems.Add(reader["ShowTime"].ToString());
                        item.SubItems.Add(reader["Room"].ToString());
                        uxShowtimeListView.Items.Add(item);
                        row++;
                    }
                }
            }
            connection.Close();
        }

        private void uxBuyTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxShowtimeListView.SelectedItems.Count < 1) throw new Exception("Please select a ticket");
                int showingID = ShowID();
                if (showingID == -1) throw new Exception("Error in getting showing ID");                
                buyticketHandler(showingID);
                MessageBox.Show("Ticket successfully purchased for " + uxShowtimeListView.SelectedItems[0].SubItems[0].Text + " at " + uxShowtimeListView.SelectedItems[0].SubItems[3].Text);
                uxShowtimeListView.SelectedItems.Clear(); 
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message);
            }            
        }
        private int ShowID()
        {
            int id = -1;
            connection.Close();
            cmd.Parameters.Clear();
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.GetShowingID";
            cmd.Connection = connection;

            SqlParameter theaternameparam = new SqlParameter();
            theaternameparam.ParameterName = "@TheaterName";
            theaternameparam.SqlDbType = System.Data.SqlDbType.NVarChar;
            theaternameparam.Direction = System.Data.ParameterDirection.Input;
            theaternameparam.Value = uxShowtimeListView.SelectedItems[0].SubItems[1].Text;

            SqlParameter movieparam = new SqlParameter();
            movieparam.ParameterName = "@MovieName";
            movieparam.SqlDbType = System.Data.SqlDbType.NVarChar;
            movieparam.Direction = System.Data.ParameterDirection.Input;
            movieparam.Value = uxShowtimeListView.SelectedItems[0].SubItems[0].Text;

            SqlParameter timeparam = new SqlParameter();
            timeparam.ParameterName = "@ShowTime";
            timeparam.SqlDbType = System.Data.SqlDbType.Time;
            timeparam.Direction = System.Data.ParameterDirection.Input;
            timeparam.Value = uxShowtimeListView.SelectedItems[0].SubItems[3].Text;

            cmd.Parameters.Add(theaternameparam);
            cmd.Parameters.Add(movieparam);
            cmd.Parameters.Add(timeparam);
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["ID"]);
                }
            }
            connection.Close();
            return id;
        }
    }
}
