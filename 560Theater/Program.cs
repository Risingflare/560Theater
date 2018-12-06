using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _560Theater
{
    public delegate void LoginDel(bool isCustomer, string email, string psw, uxLoginScreen login);
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
            LoginScreenController controller = new LoginScreenController();
            Application.Run(new uxLoginScreen(controller.Login));
        }
    }
}
