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
    public partial class CreateAccount : Form
    {

        SqlConnection _connection = new SqlConnection("Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False");
        SqlCommand _cmd = new SqlCommand();
        SqlDataReader _reader;
        SqlDataAdapter _update;
        public CreateAccount()
        {
            InitializeComponent();
        }

        // CREATE ACCOUNT BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(uxFNameTxtbox.Text) || String.IsNullOrEmpty(uxLastNameTxt.Text) || String.IsNullOrEmpty(uxEmailAddressTxt.Text) || String.IsNullOrEmpty(uxPasswordTxt.Text))
            {
                uxPasswordTxt.Clear();
                MessageBox.Show("Missing Fields Required");
            }

        }
        /*connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.AdminGetMovies";
            cmd.Connection = connection;
            connection.Close();
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
            }*/


    }
}
