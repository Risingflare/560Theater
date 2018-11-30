using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SQL_Connect
{
    class PersonConnection : PersonRepo
    {
        /*const string connectionString = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False";

        SqlConnection con = new SqlConnection(connectionString);

        public String GetName()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM PersonTest";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            sa.Fill(dt);
            // dataGridView.DataSource = dt
            con.Close();

            return "";
        }*/

        //public Person 
    }
}
