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
        SqlConnection connectionconnection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();

        public AdminGUI(uxLoginScreen login)
        {
            loginScreen = login;
            updateMovieTable();
            updateTheaterTable();
            updateShowingTable();
            InitializeComponent();
        }

        private void updateMovieTable()
        {
            //TODO: this
        }

        private void updateTheaterTable()
        {
            //TODO: this
        }

        private void updateShowingTable()
        {
            //TODO: this
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
                        //TODO: this
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
                        //TODO: this
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
                    String movieName = textBox1.Text;
                    String genre = textBox2.Text;
                    int releaseYear = int.Parse(textBox3.Text);
                    //TODO: this
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
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
                    String theaterName = textBox1.Text;
                    String Location = textBox2.Text;
                    //TODO: this
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            //TODO: this
        }

        private void indexChange(object sender, EventArgs e)
        {
            if(tabControl.SelectedTab.Name.Equals("Movie"))
            {
                updateMovieTable();
                addBtn.Enabled = true;
                editBtn.Enabled = true;
                deleteBtn.Enabled = true;
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
            else if(tabControl.SelectedTab.Name.Equals("Theater"))
            {
                updateTheaterTable();
                addBtn.Enabled = true;
                editBtn.Enabled = true;
                deleteBtn.Enabled = true;
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
            else if(tabControl.SelectedTab.Name.Equals("Showing"))
            {
                updateShowingTable();
                addBtn.Enabled = false;
                editBtn.Enabled = false;
                deleteBtn.Enabled = false;
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
    }
}
