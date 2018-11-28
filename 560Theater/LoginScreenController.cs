using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    /// Handles the populating of the movie list box when the Customer form gets open.
    /// </summary>
    public delegate void ShowMoviesDel();
    /// <summary>
    /// Handles the populating of the theater list box when the Customer form gets open.
    /// </summary>
    public delegate void ShowTheatersDel();
    /// <summary>
    public delegate void GenerateShowingDel();
    /// This delegate handles the showing of the string to the list boxes.
    /// </summary>
    /// <param name="name"></param>
    public delegate void ListBoxTheaterMovie(string name);
    /// <summary>
    class LoginScreenController
    {
        /// <summary>
        /// Opens either the admin or customer form.
        /// It also transfers the Login screen so it can be reopened whenever we close the other forms.
        /// </summary>
        /// <param name="number">This is a temporary number to get the forms working</param>
        /// <param name="login">The login form</param>
        public void Login(int number, uxLoginScreen login)
        {
            if(number == 1)
            {
                AdminGUI adminGui = new AdminGUI(login);
                adminGui.Show();
            }
            if(number == 2)
            {
                int customerID = 0;//We will get this from the authentication
                Form1Controller controller = new Form1Controller(customerID);
                uxCustomerUI customerUI = new uxCustomerUI(controller.Showtimes, controller.History, controller.GetMovieList, controller.GetTheaterList, controller.GenerateShowtimes, login);
                controller.UpdateMovies(customerUI.UpdateMovie);
                controller.UpdateTheater(customerUI.UpdateTheater);
                customerUI.Show();
            }
        }
    }
}
