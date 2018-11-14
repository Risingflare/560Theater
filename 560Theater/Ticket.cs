using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _560Theater
{
    /// <summary>
    /// Ticket object that will be used when we need a showtime
    /// </summary>
    public class Ticket
    {
        string _moviename;
        string _theatername;
        DateTime _showtime;
        int _room;
        public Ticket(string moviename,string theatername, DateTime showtime, int room)
        {
            _moviename = moviename;
            _theatername = theatername;
            _showtime = showtime;
            _room = room;
        }
        /// <summary>
        /// Property that sets or gets the MovieName as a string
        /// </summary>
        public string MovieName { get => _moviename; set => _moviename = value; }
        /// <summary>
        /// Property that sets or gets the TheaterName as a string
        /// </summary>
        public string TheaterName { get => _theatername; set => _theatername = value; }
        /// <summary>
        /// Property that sets or gets the Showtime as a DataTime
        /// </summary>
        public DateTime Showtime { get => _showtime; set => _showtime = value; }
        /// <summary>
        /// Property that sets or gets the Room as an int
        /// </summary>
        public int Room { get => _room; set => _room = value; }

    }
}
