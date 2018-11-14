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
        public HistoryGUIController(SqlConnection connection, SqlCommand cmd, SqlDataReader reader)
        {
            this.connection = connection;
            this.cmd = cmd;
            this.reader = reader;
        }
        /// <summary>
        /// This code needs some updates but I need to see the procedure so I can execute it correctly.
        /// </summary>
        public void HistoryGetTicketList()
        {
            List<Ticket> _ticketList = new List<Ticket>();
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "StoredProcedureName";
            cmd.Connection = connection;
            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string moviename = reader["MovieName"].ToString();
                    string theatername = reader["TheaterName"].ToString();
                    DateTime showtime = Convert.ToDateTime(reader["ShowTime"]);
                    int room = Convert.ToInt32(reader["Room"]);
                    Ticket ticket = new Ticket(moviename, theatername, showtime, room);
                    _ticketList.Add(ticket);
                }
            }
            connection.Close();
        }
        /// <summary>
        /// Gets the prodecure that deactivates that ticket
        /// </summary>
        /// <param name="ticket"></param>
        public void HistoryRemoveTicket(string ticket)
        {
            connection.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "StoredProcedureName";
            cmd.Connection = connection;
            cmd.Parameters.AddWithValue("@ticket", ticket);

        }
    }
}
