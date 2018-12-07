using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _560Theater
{
    public partial class AdminGUI : Form
    {
        uxLoginScreen loginScreen;
        SqlConnection connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;
        List<string> movieL;
        List<string> theaterL;
        List<string> locationL;
        List<string> movienames;
        List<string> theaternames;
        List<string> theaterLocation;
        public AdminGUI(uxLoginScreen login)
        {
            loginScreen = login;
            InitializeComponent();
            movieL = new List<string>();
            theaterL = new List<string>();
            locationL = new List<string>();
            movienames = new List<string>();
            theaternames = new List<string>();
            theaterLocation = new List<string>();
            updateMovieTable();
            updateTheaterTable();
            updateShowingTable(); 
        }

        private void updateMovieTable()
        {
            connection.Close();
            movieList.Items.Clear();
            cmd.Parameters.Clear();
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.AdminGetMovies";
            cmd.Connection = connection;
            int row = 0;
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MovieID"].ToString(), row);
                    string moviename = reader["MovieName"].ToString();
                    movienames.Add(moviename);
                    item.SubItems.Add(moviename);
                    movieL.Add(moviename);
                    item.SubItems.Add(reader["ReleaseYear"].ToString());
                    item.SubItems.Add(reader["Genre"].ToString());
                    item.SubItems.Add(reader["IsActive"].ToString());
                    item.SubItems.Add(reader["CreatedOn"].ToString());
                    item.SubItems.Add(reader["UpdatedOn"].ToString());
                    movieList.Items.Add(item);
                    row++;
                }
            }
            movieList.Update();
            connection.Close();
        }

        private void updateTheaterTable()
        {
            connection.Close();
            theaterList.Items.Clear();
            cmd.Parameters.Clear();
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.AdminGetTheater";
            cmd.Connection = connection;
            int row = 0;

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["TheaterID"].ToString());
                    string theatername = reader["TheaterName"].ToString();
                    theaternames.Add(theatername);
                    item.SubItems.Add(theatername);
                    theaterL.Add(theatername);
                    string location = reader["Location"].ToString();
                    theaterLocation.Add(location);
                    item.SubItems.Add(location);
                    locationL.Add(location);
                    item.SubItems.Add(reader["IsActive"].ToString());
                    item.SubItems.Add(reader["CreatedOn"].ToString());
                    item.SubItems.Add(reader["UpdatedOn"].ToString());
                    theaterList.Items.Add(item);
                    row++;
                }
            }
            theaterList.Update();
            connection.Close();
        }

        private void updateShowingTable()
        {
            connection.Close();
            showingList.Items.Clear();
            cmd.Parameters.Clear();
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.AdminGetShowing";
            cmd.Connection = connection;
            int row = 0;

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ShowingID"].ToString(), row);
                    item.SubItems.Add(reader["TheaterName"].ToString());
                    item.SubItems.Add(reader["MovieName"].ToString());
                    item.SubItems.Add(reader["Room"].ToString());
                    item.SubItems.Add(reader["ShowTime"].ToString());
                    item.SubItems.Add(reader["Location"].ToString());
                    item.SubItems.Add(reader["IsActive"].ToString());
                    item.SubItems.Add(reader["CreatedOn"].ToString());
                    item.SubItems.Add(reader["UpdatedOn"].ToString());
                    showingList.Items.Add(item);
                    row++;
                }
            }
            showingList.Update();
            connection.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name.Equals("Movie"))
            {
                try
                {
                    if (textBox1.Text.Length == 0)
                    {
                        MessageBox.Show("Movie Name Required");
                    }
                    else if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Movie Genre Required");
                    }
                    else if (textBox3.Text.Length == 0)
                    {
                        MessageBox.Show("Release Year Required");
                    }
                    else
                    {
                        String movieName = textBox1.Text;
                        String genre = textBox2.Text;
                        int releaseYear = int.Parse(textBox3.Text);


                        connection.Open();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "dbo.AddMovie";
                        cmd.Connection = connection;

                        SqlParameter name = new SqlParameter();
                        name.ParameterName = "@MovieName";
                        name.SqlDbType = System.Data.SqlDbType.NVarChar;
                        name.Direction = System.Data.ParameterDirection.Input;
                        name.Value = movieName;
                        cmd.Parameters.Add(name);

                        SqlParameter Mgenre = new SqlParameter();
                        Mgenre.ParameterName = "@Genre";
                        Mgenre.SqlDbType = System.Data.SqlDbType.NVarChar;
                        Mgenre.Direction = System.Data.ParameterDirection.Input;
                        Mgenre.Value = genre;
                        cmd.Parameters.Add(Mgenre);

                        SqlParameter year = new SqlParameter();
                        year.ParameterName = "@ReleaseYear";
                        year.SqlDbType = System.Data.SqlDbType.Int;
                        year.Direction = System.Data.ParameterDirection.Input;
                        year.Value = releaseYear;
                        cmd.Parameters.Add(year);

                        cmd.ExecuteNonQuery();

                        connection.Close();
                        cmd.Parameters.Clear();
                        updateMovieTable();
                        GenerateNewShowingsMovies(movieName);

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
            else if (tabControl.SelectedTab.Name.Equals("Theater"))
            {
                try
                {
                    if (textBox1.Text.Length == 0)
                    {
                        MessageBox.Show("Theater Name Required");
                    }
                    else if (textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Theater Location Required");
                    }
                    else
                    {
                        String theaterName = textBox1.Text;
                        String Location = textBox2.Text;


                        connection.Open();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "dbo.AddTheater";
                        cmd.Connection = connection;

                        SqlParameter name = new SqlParameter();
                        name.ParameterName = "@TheaterName";
                        name.SqlDbType = System.Data.SqlDbType.NVarChar;
                        name.Direction = System.Data.ParameterDirection.Input;
                        name.Value = theaterName;
                        cmd.Parameters.Add(name);

                        SqlParameter Tlocation = new SqlParameter();
                        Tlocation.ParameterName = "@Location";
                        Tlocation.SqlDbType = System.Data.SqlDbType.NVarChar;
                        Tlocation.Direction = System.Data.ParameterDirection.Input;
                        Tlocation.Value = Location;
                        cmd.Parameters.Add(Tlocation);

                        cmd.ExecuteNonQuery();

                        connection.Close();
                        cmd.Parameters.Clear();
                        updateTheaterTable();
                        GenerateShowingTheaterLocation(theaterName, Location);

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name.Equals("Movie"))
            {
                try
                {
                    if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0 && textBox3.Text.Length == 0)
                    {
                        MessageBox.Show("Enter one or more parameters to be updated");
                    }
                    else if (movieList.SelectedItems == null)
                    {
                        MessageBox.Show("Select an item to edit");
                    }
                    else
                    {
                        String movieName = textBox1.Text.Trim();
                        String genre = textBox2.Text.Trim();
                        int releaseYear;
                        int movieId = int.Parse(movieList.SelectedItems[0].Text);

                        if (textBox3.Text.Trim() == "")
                        {
                            int.TryParse(movieList.SelectedItems[0].SubItems[2].Text, out releaseYear);
                        }
                        else
                        {
                            int.TryParse(textBox3.Text, out releaseYear);
                        }

                        if (movieName.Length == 0)
                        {
                            movieName = movieList.SelectedItems[0].SubItems[1].Text;
                        }

                        if (genre.Length == 0)
                        {
                            genre = movieList.SelectedItems[0].SubItems[3].Text;
                        }


                        connection.Open();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "dbo.AdminEditMovie";
                        cmd.Connection = connection;

                        SqlParameter id = new SqlParameter();
                        id.ParameterName = "@MovieID";
                        id.SqlDbType = System.Data.SqlDbType.Int;
                        id.Direction = System.Data.ParameterDirection.Input;
                        id.Value = movieId;
                        cmd.Parameters.Add(id);

                        SqlParameter name = new SqlParameter();
                        name.ParameterName = "@MovieName";
                        name.SqlDbType = System.Data.SqlDbType.NVarChar;
                        name.Direction = System.Data.ParameterDirection.Input;
                        name.Value = movieName;
                        cmd.Parameters.Add(name);

                        SqlParameter Mgenre = new SqlParameter();
                        Mgenre.ParameterName = "@Genre";
                        Mgenre.SqlDbType = System.Data.SqlDbType.NVarChar;
                        Mgenre.Direction = System.Data.ParameterDirection.Input;
                        Mgenre.Value = genre;
                        cmd.Parameters.Add(Mgenre);

                        SqlParameter year = new SqlParameter();
                        year.ParameterName = "@ReleaseYear";
                        year.SqlDbType = System.Data.SqlDbType.Int;
                        year.Direction = System.Data.ParameterDirection.Input;
                        year.Value = releaseYear;
                        cmd.Parameters.Add(year);

                        cmd.ExecuteNonQuery();

                        connection.Close();
                        cmd.Parameters.Clear();
                        updateMovieTable();


                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
            else if (tabControl.SelectedTab.Name.Equals("Theater"))
            {
                try
                {
                    if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
                    {
                        MessageBox.Show("Enter one or more parameters to be updated");
                    }
                    else if (theaterList.SelectedItems == null)
                    {
                        MessageBox.Show("Select an item to edit");
                    }
                    else
                    {
                        String theaterName = textBox1.Text;
                        String Location = textBox2.Text;
                        int theaterId = int.Parse(theaterList.SelectedItems[0].Text);

                        if (theaterName.Length == 0)
                        {
                            theaterName = theaterList.SelectedItems[0].SubItems[0].Text;
                        }

                        if (Location.Length == 0)
                        {
                            Location = theaterList.SelectedItems[0].SubItems[1].Text;
                        }

                        connection.Open();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "dbo.AdminEditTheater";
                        cmd.Connection = connection;

                        SqlParameter id = new SqlParameter();
                        id.ParameterName = "@TheaterID";
                        id.SqlDbType = System.Data.SqlDbType.Int;
                        id.Direction = System.Data.ParameterDirection.Input;
                        id.Value = theaterId;
                        cmd.Parameters.Add(id);

                        SqlParameter name = new SqlParameter();
                        name.ParameterName = "@TheaterName";
                        name.SqlDbType = System.Data.SqlDbType.NVarChar;
                        name.Direction = System.Data.ParameterDirection.Input;
                        name.Value = theaterName;
                        cmd.Parameters.Add(name);

                        SqlParameter Tlocation = new SqlParameter();
                        Tlocation.ParameterName = "@Location";
                        Tlocation.SqlDbType = System.Data.SqlDbType.NVarChar;
                        Tlocation.Direction = System.Data.ParameterDirection.Input;
                        Tlocation.Value = Location;
                        cmd.Parameters.Add(Tlocation);

                        cmd.ExecuteNonQuery();

                        connection.Close();
                        cmd.Parameters.Clear();
                        updateTheaterTable();


                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name.Equals("Movie"))
            {
                if(movieList.SelectedItems != null)
                {
                    connection.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.AdminDeleteMovie";
                    cmd.Connection = connection;

                    SqlParameter id = new SqlParameter();
                    id.ParameterName = "@id";
                    id.SqlDbType = System.Data.SqlDbType.Int;
                    id.Direction = System.Data.ParameterDirection.Input;
                    id.Value = int.Parse(movieList.SelectedItems[0].Text);
                    cmd.Parameters.Add(id);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                    cmd.Parameters.Clear();
                    updateMovieTable();
                }
            }
            else if (tabControl.SelectedTab.Name.Equals("Theater"))
            {
                if(theaterList.SelectedItems != null)
                {
                    connection.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.AdminDeleteTheater";
                    cmd.Connection = connection;

                    SqlParameter id = new SqlParameter();
                    id.ParameterName = "@id";
                    id.SqlDbType = System.Data.SqlDbType.Int;
                    id.Direction = System.Data.ParameterDirection.Input;
                    id.Value = int.Parse(theaterList.SelectedItems[0].Text);
                    cmd.Parameters.Add(id);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                    cmd.Parameters.Clear();
                    updateTheaterTable();
                }
            }
            else if (tabControl.SelectedTab.Name.Equals("Showing"))
            {
                if(showingList.SelectedItems != null)
                {
                    connection.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.AdminDeleteShowing";
                    cmd.Connection = connection;

                    SqlParameter id = new SqlParameter();
                    id.ParameterName = "@id";
                    id.SqlDbType = System.Data.SqlDbType.Int;
                    id.Direction = System.Data.ParameterDirection.Input;
                    id.Value = int.Parse(showingList.SelectedItems[0].Text);
                    cmd.Parameters.Add(id);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                    cmd.Parameters.Clear();
                    updateShowingTable();
                }
            }
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name.Equals("Movie"))
            {
                if (movieList.SelectedItems != null)
                {
                    connection.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.ActivateMovie";
                    cmd.Connection = connection;

                    SqlParameter id = new SqlParameter();
                    id.ParameterName = "@id";
                    id.SqlDbType = System.Data.SqlDbType.Int;
                    id.Direction = System.Data.ParameterDirection.Input;
                    id.Value = int.Parse(movieList.SelectedItems[0].Text);
                    cmd.Parameters.Add(id);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                    cmd.Parameters.Clear();
                    updateMovieTable();
                }
            }
            else if (tabControl.SelectedTab.Name.Equals("Theater"))
            {
                if (theaterList.SelectedItems != null)
                {
                    connection.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.ActivateTheater";
                    cmd.Connection = connection;

                    SqlParameter id = new SqlParameter();
                    id.ParameterName = "@id";
                    id.SqlDbType = System.Data.SqlDbType.Int;
                    id.Direction = System.Data.ParameterDirection.Input;
                    id.Value = int.Parse(theaterList.SelectedItems[0].Text);
                    cmd.Parameters.Add(id);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                    cmd.Parameters.Clear();
                    updateTheaterTable();
                }
            }
            else if (tabControl.SelectedTab.Name.Equals("Showing"))
            {
                if (showingList.SelectedItems != null)
                {
                    connection.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.ActivateShowing";
                    cmd.Connection = connection;

                    SqlParameter id = new SqlParameter();
                    id.ParameterName = "@id";
                    id.SqlDbType = System.Data.SqlDbType.Int;
                    id.Direction = System.Data.ParameterDirection.Input;
                    id.Value = int.Parse(showingList.SelectedItems[0].Text);
                    cmd.Parameters.Add(id);

                    cmd.ExecuteNonQuery();

                    connection.Close();
                    cmd.Parameters.Clear();
                    updateShowingTable();
                }
            }
        }

        private void indexChange(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name.Equals("Movie"))
            {
                updateMovieTable();
                addBtn.Enabled = true;
                editBtn.Enabled = true;
                label1.Text = "Movie Name:";
                label1.Show();
                label2.Text = "Genre:";
                label2.Show();
                label3.Show();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
            }
            else if (tabControl.SelectedTab.Name.Equals("Theater"))
            {
                updateTheaterTable();
                addBtn.Enabled = true;
                editBtn.Enabled = false;
                label1.Text = "Theater Name:";
                label1.Show();
                label2.Text = "Location";
                label2.Show();
                label3.Hide();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Show();
                textBox2.Show();
                textBox3.Hide();
            }
            else if (tabControl.SelectedTab.Name.Equals("Showing"))
            {
                updateShowingTable();
                addBtn.Enabled = false;
                editBtn.Enabled = false;
                label1.Hide();
                label2.Hide();
                label3.Hide();
                textBox1.Hide();
                textBox2.Hide();
                textBox3.Hide();
            }
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            loginScreen.Show();
        }

        private void GenerateNewShowingsMovies(string moviename)
        {
            string showtime;
            List<string> usedShowtimes = new List<string>();
            int[] hours = new int[] { 14, 15, 16, 17, 18, 19, 20 };
            int[] minutes = new int[] { 0, 15, 30, 45 };
            Random rn = new Random();
            for (int k = 0; k < theaterL.Count; k++)
            {
                usedShowtimes.Clear();
                cmd.Parameters.Clear();
                connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "dbo.GetTimes";
                cmd.Connection = connection;
                SqlParameter theaternameparam = new SqlParameter();
                theaternameparam.ParameterName = "@TheaterName";
                theaternameparam.SqlDbType = System.Data.SqlDbType.NVarChar;
                theaternameparam.Direction = System.Data.ParameterDirection.Input;
                theaternameparam.Value = theaterL[k];
                cmd.Parameters.Add(theaternameparam);
                using (reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string times = reader["Times"].ToString();
                        usedShowtimes.Add(times);
                    }
                }
                connection.Close();
                int count = 0;
                while (count < 1)
                {
                    cmd.Parameters.Clear();
                    int i = rn.Next(0, 6);
                    int j = rn.Next(0, 3);
                    int room = rn.Next(1, 9);
                    int hour = hours[i];
                    int minute = minutes[j];
                    if (minute == 0)
                    {
                        showtime = hour.ToString() + ":00" + ":00";
                    }
                    else
                    {
                        showtime = hour.ToString() + ":" + minute.ToString() + ":00";
                    }
                    if (usedShowtimes.Contains(showtime) == false)
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "dbo.CreateShowing";//This is getting the theater list procedure
                        cmd.Connection = connection;

                        SqlParameter theatername = new SqlParameter();
                        theatername.ParameterName = "@TheaterName";
                        theatername.SqlDbType = System.Data.SqlDbType.NVarChar;
                        theatername.Direction = System.Data.ParameterDirection.Input;
                        theatername.Value = theaterL[k];

                        SqlParameter movienameparam = new SqlParameter();
                        movienameparam.ParameterName = "@MovieName";
                        movienameparam.SqlDbType = System.Data.SqlDbType.NVarChar;
                        movienameparam.Direction = System.Data.ParameterDirection.Input;
                        movienameparam.Value = moviename;

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
                        location.Value = locationL[k];

                        cmd.Parameters.Add(theatername);
                        cmd.Parameters.Add(movienameparam);
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
        private void GenerateShowingTheaterLocation(string theater, string location)
        {
            string showtime;
            List<string> usedShowtimes = new List<string>();
            int[] hours = new int[] { 14, 15, 16, 17, 18, 19, 20 };
            int[] minutes = new int[] { 0, 15, 30, 45 };
            Random rn = new Random();
            usedShowtimes.Clear();
            int count = 0;
            while (count < 5)
            {
                cmd.Parameters.Clear();
                int i = rn.Next(0, 6);
                int j = rn.Next(0, 3);
                int room = rn.Next(1, 9);
                int m = rn.Next(0, movieL.Count - 1);
                int hour = hours[i];
                int minute = minutes[j];
                if (minute == 0)
                {
                    showtime = hour.ToString() + ":00" + ":00";
                }
                else
                {
                    showtime = hour.ToString() + ":" + minute.ToString() + ":00";
                }
                if (usedShowtimes.Contains(showtime) == false)
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.CreateShowing";//This is getting the theater list procedure
                    cmd.Connection = connection;

                    SqlParameter theatername = new SqlParameter();
                    theatername.ParameterName = "@TheaterName";
                    theatername.SqlDbType = System.Data.SqlDbType.NVarChar;
                    theatername.Direction = System.Data.ParameterDirection.Input;
                    theatername.Value = theater;

                    SqlParameter moviename = new SqlParameter();
                    moviename.ParameterName = "@MovieName";
                    moviename.SqlDbType = System.Data.SqlDbType.NVarChar;
                    moviename.Direction = System.Data.ParameterDirection.Input;
                    moviename.Value = movieL[m];

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

                    SqlParameter locationparam = new SqlParameter();
                    locationparam.ParameterName = "@Location";
                    locationparam.SqlDbType = System.Data.SqlDbType.NVarChar;
                    locationparam.Direction = System.Data.ParameterDirection.Input;
                    locationparam.Value = location;

                    cmd.Parameters.Add(theatername);
                    cmd.Parameters.Add(moviename);
                    cmd.Parameters.Add(roomnum);
                    cmd.Parameters.Add(showtimeparam);
                    cmd.Parameters.Add(locationparam);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    usedShowtimes.Add(showtime);
                    count++;
                }
            }
        }

        private void uxGenerateShowings_Click(object sender, EventArgs e)
        {
            string showtime;
            List<string> usedShowtimes = new List<string>();
            int[] hours = new int[] { 14, 15, 16, 17, 18, 19, 20 };
            int[] minutes = new int[] { 0, 15, 30, 45 };
            Random rn = new Random();
            for (int k = 0; k < theaternames.Count; k++)
            {
                usedShowtimes.Clear();
                int count = 0;
                while (count < 5)
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
                        showtime = hour.ToString() + ":" + minute.ToString() + ":00";
                    }
                    if (usedShowtimes.Contains(showtime) == false)
                    {
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
            MessageBox.Show("New Showings are generated, please don't hit this button again as does not drop the showing table.");
        }
    }
}
