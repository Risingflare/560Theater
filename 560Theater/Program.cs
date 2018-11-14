using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _560Theater
{
    /// <summary>
    /// Handles the Show Showtime click.
    /// </summary>
    public delegate void ShowShowtimeDel(string moviename, string theatername, string time);
    /// <summary>
    /// Handles the History click
    /// </summary>
    public delegate void ShowHistoryDel();
    /// <summary>
    /// Runs the program
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1Controller controller = new Form1Controller();
            Application.Run(new uxCustomerUI(controller.Showtimes,controller.History));
        }
    }
}
