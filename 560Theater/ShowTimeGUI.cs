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
        
        public ShowTimeGUI(SqlConnection connection, SqlCommand cmd, SqlDataReader reader, string moviename, string theatername, string time)
        {
            InitializeComponent();
            this.connection = connection;
            this.cmd = cmd;
            this.reader = reader;
            UpdateShowtime(moviename, theatername, time);
        }

        private void ShowTimeGUI_Load(object sender, EventArgs e)
        {

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
                    ListViewItem item = new ListViewItem(reader["MovieName"].ToString(), row);
                    item.SubItems.Add(reader["TheaterName"].ToString());
                    item.SubItems.Add(reader["ShowTime"].ToString());
                    item.SubItems.Add(reader["Room"].ToString());
                    uxShowtimeListView.Items.Add(item);
                    row++;
                }
            }
            connection.Close();
        }
    }
}
