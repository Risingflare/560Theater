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

        public ShowTimeController(SqlConnection connection, SqlCommand cmd, SqlDataReader reader)
        {
            this.connection = connection;
            this.cmd = cmd;
            this.reader = reader;
        }
    }
}
