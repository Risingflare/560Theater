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

        public AdminGUI(uxLoginScreen login)
        {
            loginScreen = login;
            InitializeComponent();
            updateMovieTable();
            updateTheaterTable();
            updateShowingTable();
        }

        private void updateMovieTable()
        {
            movieList.Items.Clear();
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
                    item.SubItems.Add(reader["MovieName"].ToString());
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
            theaterList.Items.Clear();
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
                    item.SubItems.Add(reader["TheaterName"].ToString());
                    item.SubItems.Add(reader["Location"].ToString());
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
            showingList.Items.Clear();
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
                    if(textBox1.Text.Length == 0)
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


                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                    }
                }
                catch(Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
            else if(tabControl.SelectedTab.Name.Equals("Theater"))
            {
                try
                {
                    if(textBox1.Text.Length == 0)
                    {
                        MessageBox.Show("Theater Name Required");
                    }
                    else if(textBox2.Text.Length == 0)
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
                    if(textBox1.Text.Length == 0 && textBox2.Text.Length == 0 && textBox3.Text.Length == 0)
                    {
                        MessageBox.Show("Enter one or more parameters to be updated");
                    }
                    else
                    {
                        String movieName = textBox1.Text;
                        String genre = textBox2.Text;
                        int releaseYear;

                        if (textBox3.Text.Length == 0)
                        {
                            releaseYear = int.Parse(movieList.SelectedItems[0].SubItems[2].Text);
                        }
                        else
                        {
                            releaseYear = int.Parse(textBox3.Text);
                        }

                        if (movieName.Length == 0)
                        {
                            movieName = movieList.SelectedItems[0].SubItems[0].Text;
                        }

                        if (genre.Length == 0)
                        {
                            genre = movieList.SelectedItems[0].SubItems[1].Text;
                        }


                        connection.Open();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "dbo.AdminEditMovie";
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
                    else
                    {
                        String theaterName = textBox1.Text;
                        String Location = textBox2.Text;

                        if(theaterName.Length == 0)
                        {
                            theaterName = theaterList.SelectedItems[0].SubItems[0].Text;
                        }

                        if(Location.Length == 0)
                        {
                            Location = theaterList.SelectedItems[0].SubItems[1].Text;
                        }

                        connection.Open();
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandText = "dbo.AdminEditTheater";
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
            else if (tabControl.SelectedTab.Name.Equals("Theater"))
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
                updateMovieTable();
            }
            else if(tabControl.SelectedTab.Name.Equals("Showing"))
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
                updateMovieTable();
            }
        }

        private void indexChange(object sender, EventArgs e)
        {
            if(tabControl.SelectedTab.Name.Equals("Movie"))
            {
                updateMovieTable();
                editBtn.Enabled = true;
                label1.Text = "Movie Name:";
                label1.Show();
                label2.Text = "Genre:";
                label2.Show();
                label3.Show();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox3.Show();
            }
            else if(tabControl.SelectedTab.Name.Equals("Theater"))
            {
                updateTheaterTable();
                editBtn.Enabled = true;
                label1.Text = "Theater Name:";
                label1.Show();
                label2.Text = "Location";
                label2.Show();
                label3.Hide();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox3.Hide();
            }
            else if(tabControl.SelectedTab.Name.Equals("Showing"))
            {
                updateShowingTable();
                editBtn.Enabled = false;
                label1.Hide();
                label2.Hide();
                label3.Hide();
                textBox3.Show();
            }
        }

        private void onClose(object sender, FormClosedEventArgs e)
        {
            loginScreen.Show();
        }
    }
}
