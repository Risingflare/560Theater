using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _560Theater
{
    public class ShowTimeController
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;
        int customerID;

        public ShowTimeController(SqlConnection connection, SqlCommand cmd, SqlDataReader reader, int customerID)
        {
            this.connection = connection;
            this.cmd = cmd;
            this.reader = reader;
            this.customerID = customerID;
        }

        public void BuyTicket(int showingID)
        {
            cmd.Parameters.Clear();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.CreateTicket";
            cmd.Connection = connection;
            SqlParameter customerIDparameter = new SqlParameter();
            customerIDparameter.ParameterName = "@CustomerId";
            customerIDparameter.SqlDbType = System.Data.SqlDbType.Int;
            customerIDparameter.Direction = System.Data.ParameterDirection.Input;
            customerIDparameter.Value = customerID;
            SqlParameter showingIDparameter = new SqlParameter();
            showingIDparameter.ParameterName = "@ShowingId";
            showingIDparameter.SqlDbType = System.Data.SqlDbType.Int;
            showingIDparameter.Direction = System.Data.ParameterDirection.Input;
            showingIDparameter.Value = showingID;
            cmd.Parameters.Add(customerIDparameter);
            cmd.Parameters.Add(showingIDparameter);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();           
        }
    }
}
