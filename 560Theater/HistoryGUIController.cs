using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _560Theater
{
    class HistoryGUIController
    {
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader reader;
        int customerId;
        List<ListViewTicketHistory> ticketObs;
        Dictionary<int, string> tickets;
        List<int> ticketIDList;
        public HistoryGUIController(SqlConnection connection, SqlCommand cmd, SqlDataReader reader, int customerId)
        {
            this.connection = connection;
            this.cmd = cmd;
            this.reader = reader;
            this.customerId = customerId;
            ticketObs = new List<ListViewTicketHistory>();
            ticketIDList = new List<int>();
            tickets = new Dictionary<int, string>();
        }
        public void UpdateTicketForm(ListViewTicketHistory ticket)
        {
            ticketObs.Add(ticket);
        }
        public void GetTickets()
        {
            connection.Close();
            cmd.Parameters.Clear();
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.GetTicket";
            cmd.Connection = connection;

            SqlParameter customerIdparameter = new SqlParameter();
            customerIdparameter.ParameterName = "@CustomerId";
            customerIdparameter.SqlDbType = System.Data.SqlDbType.Int;
            customerIdparameter.Direction = System.Data.ParameterDirection.Input;
            customerIdparameter.Value = customerId;

            cmd.Parameters.Add(customerIdparameter);
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string line = "";
                    bool b = (bool)reader["Active"];
                    if (b)
                    {
                        string moviename = reader["MovieName"].ToString();
                        string theater = reader["TheaterName"].ToString();
                        string location = reader["Location"].ToString();
                        string showtime = reader["ShowTime"].ToString();
                        string room = reader["Room"].ToString();
                        string createdOn = reader["CreatedOn"].ToString();
                        int ticketID = Convert.ToInt32(reader["ID"]);
                        line = moviename + "," + theater + "," + location + "," + showtime + "," + room + "," + createdOn;
                        ticketIDList.Add(ticketID);
                        tickets.Add(ticketID, line);
                    }
                }
            }
            connection.Close();
            foreach(KeyValuePair<int,string> ticket in tickets)
            {
                foreach(ListViewTicketHistory ob in ticketObs)
                {
                    ob(ticket.Value);
                }
            }
        }
        /// <summary>
        /// Gets the prodecure that deactivates that ticket
        /// </summary>
        /// <param name="ticket"></param>
        public void HistoryRemoveTicket(int index)
        {
            int ticketId = ticketIDList[index];
            cmd.Parameters.Clear();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "dbo.CustomerDeleteTicket";
            cmd.Connection = connection;
            SqlParameter ticketIdparam = new SqlParameter();
            ticketIdparam.ParameterName = "@TicketId";
            ticketIdparam.SqlDbType = System.Data.SqlDbType.Int;
            ticketIdparam.Direction = System.Data.ParameterDirection.Input;
            ticketIdparam.Value = ticketId;
            cmd.Parameters.Add(ticketIdparam);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            ticketIDList.RemoveAt(index);
            tickets.Remove(ticketId);
            foreach (KeyValuePair<int, string> ticket in tickets)
            {
                foreach (ListViewTicketHistory ob in ticketObs)
                {
                    ob(ticket.Value);
                }
            }
        }
    }
}
