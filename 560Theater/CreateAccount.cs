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
        const string connStr = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False";
        SqlConnection con = new SqlConnection(connStr);
        
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
            else
            {
                //ShowTimeGUI showings = new ShowTimeGUI();
                //this.Hide();
                //showings.ShowDialog();
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            
        }

        /*private bool isValidEmail(string newEmail)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select U.EmailAddress from dbo.[User] U where U.EmailAddress = " + newEmail;
            con.Open();
            object dummy = Enum.Parse(typeof(SqlDbType), "Your string here", true);
            SqlDbType myType = (SqlDbType.NVarChar);
            
            if (Enum.IsDefined(typeof(SqlDbType), "NVARCHAR"))
            {
                dt = (SqlDbType)Enum.Parse(typeof(SqlDbType), "NVARCHAR", true);
                . = 128;
            }
            //cmd.Parameters.AddWithValue("PersonID", personID);
            foreach (string name in Enum.Format(SqlDbType.NVarChar, newEmail, string))
            {
                Console.WriteLine(name);
            }
            var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;
            return reader.GetString(reader.GetOrdinal("FullName"));

            
            connection.Close();
        }*/
        /*private Boolean isNewEmail(string newEmail)
        {
            const string eval = "select U.EmailAddress from dbo.[User] U where U.EmailAddress = @NewEmail";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(eval, conn))
                {
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = newEmail;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        result.Load(dr);
                        string textBoxStuff = (SqlDbType.NVarChar)(newEmail."[User].EmailAddress"]);
                    }
                }
            }
            return result;
        }*/
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

        /*
         uxDisplayName.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM PersonTest PT WHERE PT.PersonID = " + personID;
            cmd.Parameters.AddWithValue("PersonID", personID);
            con.Open();
            var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;
            return reader.GetString(reader.GetOrdinal("FullName"));
         
         */

        /*
                        // Mock user's input.
                string inputStr = "NVarChar";
                int maxLength = 40;

                // Convert string to datatype.
                DataType dt = new DataType();
                if (Enum.IsDefined(typeof(SqlDataType), inputStr))
                {
                    dt.SqlDataType = (SqlDataType)Enum.Parse(typeof(SqlDataType), inputStr, false);
                    dt.MaximumLength = maxLength;
                }

By the way, we can get all SqlDataType's values like this:

                foreach (string name in Enum.GetNames(typeof(SqlDataType)))
                {
                    Console.WriteLine(name);
                }
         */


}
