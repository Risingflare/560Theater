using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        string _commandText;
        uxLoginScreen _LogScreen;
        public void Login(bool isCustomer, string email, string psw, uxLoginScreen login)
        {
            _LogScreen = login;
            if (!isCustomer) // Admin
            {
                _commandText = "GetAdminLogins";
                int UserId = AccountLogin(email, psw);
                if (UserId != -1)
                {
                    AdminGUI adminGui = new AdminGUI(login);
                    adminGui.Show();
                    _LogScreen.Hide();
                }
            }
            else if(isCustomer) // Customer
            {
                _commandText = "dbo.GetCustomerLogins";
                int UserId = AccountLogin(email, psw);
                if (UserId != -1)  // valid authentication
                {
                    Form1Controller controller = new Form1Controller(UserId);
                    uxCustomerUI customerUI = new uxCustomerUI(controller.Showtimes, controller.History, controller.GetMovieList, controller.GetTheaterList, controller.GenerateShowtimes, login);
                    controller.UpdateMovies(customerUI.UpdateMovie);
                    controller.UpdateTheater(customerUI.UpdateTheater);
                    customerUI.Show();
                    _LogScreen.Hide();
                }
            }
        }


        private int AccountLogin(string custEmail, string custPsw) // returns customer id
        {
            const string _connStr = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False";
            SqlConnection _con = new SqlConnection(_connStr);
            SqlCommand _cmd = new SqlCommand();
            SqlDataReader _reader;
            _cmd.Parameters.Clear();
            _con.Open();
            _cmd.CommandType = System.Data.CommandType.StoredProcedure;
            _cmd.CommandText = _commandText; // all users right now
            _cmd.Connection = _con;
            using (_reader = _cmd.ExecuteReader())
            {
                while (_reader.Read())
                {
                    string email = _reader["Email"].ToString();
                    string psw = _reader["Password"].ToString();
                    string id = _reader["UserID"].ToString();
                    if (custEmail == email && custPsw == psw)
                    {
                        int.TryParse(id, out int UserID);
                        _con.Close();
                        return UserID;
                    }
                }
            }
            _con.Close();
            return -1;
        }
        /// <summary>
        /// Opens either the admin or customer form.
        /// It also transfers the Login screen so it can be reopened whenever we close the other forms.
        /// </summary>
        /// <param name="number">This is a temporary number to get the forms working</param>
        /// <param name="login">The login form</param>
        /*   public void Login(int number, uxLoginScreen login)
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
           }*/
    }
}