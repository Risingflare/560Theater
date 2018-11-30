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

namespace SQL_Connect
{
    public partial class Display : Form
    {
        const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False";

        SqlConnection con = new SqlConnection(connectionString);
        public Display()
        {
            InitializeComponent();
        }

        private void uxShowData_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM PersonTest PT";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            uxGrid.DataSource = dt;
            con.Close();
        }

        public String GetName(int personID)
        {
            uxDisplayName.Clear();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM PersonTest PT WHERE PT.PersonID = " + personID;
            cmd.Parameters.AddWithValue("PersonID", personID);
            con.Open();
            var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;
            return reader.GetString(reader.GetOrdinal("FullName"));
        }

        private void uxGetPerson_Click(object sender, EventArgs e)
        {
            String temp = GetName(Convert.ToInt32(uxEnterID.Text));
            uxDisplayName.Text = temp;
            con.Close();
        }
    }
}
