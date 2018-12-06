using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _560Theater
{
    /// <summary>
    /// Creates new user account
    /// </summary>
    public partial class CreateAccount : Form
    {

        public const string _connStr = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False";
        private SqlConnection _con = new SqlConnection(_connStr);
        private SqlCommand _cmd = new SqlCommand();
        private SqlDataReader _reader;
        private LoginDel _logdel;
        private uxLoginScreen _logscreen;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logdel"></param>
        /// <param name="log"></param>
        public CreateAccount(LoginDel log, uxLoginScreen screen)
        {
            _logdel = log;
            _logscreen = screen;
            InitializeComponent();
        }

        /// <summary>
        /// Create Account Button
        /// Ensures originality and nonempty textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCreateAccountButton_Click(object sender, EventArgs e)
        {
            string _fname = uxFNameTxtbox.Text;
            string _lname = uxLastNameTxt.Text;
            string _email = uxEmailAddressTxt.Text;
            string _psw = uxPasswordTxt.Text;
            if (String.IsNullOrWhiteSpace(_fname) || String.IsNullOrWhiteSpace(_lname) || String.IsNullOrWhiteSpace(_email) || String.IsNullOrWhiteSpace(_psw))
            {
                MessageBox.Show("Missing Fields Required");
            }
            else if (!isValidEmail(_email))
            {
                MessageBox.Show("Error: " + _email + " is associated with existing account.");
            }
            else
            {
                writeOutAccount(_fname, _lname, _email, _psw);
                _logdel(true, _email, _psw, _logscreen);
                this.Hide();
            }
        }

        /// <summary>
        /// Tests originality of email
        /// </summary>
        /// <param name="userEmail"></param>
        /// <returns></returns>
        private bool isValidEmail(string userEmail)
        {
             _cmd.Parameters.Clear();
             _con.Open();
             _cmd.CommandType = System.Data.CommandType.StoredProcedure;
             _cmd.CommandText = "dbo.GetAllEmails";
             _cmd.Connection = _con;
             using (_reader = _cmd.ExecuteReader())
             {
                 while (_reader.Read())
                 {
                    string email = _reader["Email"].ToString();
                    if (userEmail == email) { _con.Close(); return false; }
                 }
             }
             _con.Close();
            return true;
        }

        /// <summary>
        /// Adds Account to [dbo].[Users] AND [dbo].[Customers]
        /// </summary>
        /// <param name="f"></param>
        /// <param name="l"></param>
        /// <param name="e"></param>
        /// <param name="p"></param>
        private void writeOutAccount(string f, string l, string e, string p)
        {
            _cmd.Parameters.Clear();
            _con.Open();
            _cmd.CommandType = System.Data.CommandType.StoredProcedure;
            _cmd.CommandText = "dbo.AddAccount";
            _cmd.Connection = _con;

            _cmd.Parameters.Add(convertToSqlParam(f, "@FirstName"));
            _cmd.Parameters.Add(convertToSqlParam(l, "@LastName"));
            _cmd.Parameters.Add(convertToSqlParam(e, "@Email"));
            _cmd.Parameters.Add(convertToSqlParam(p, "@Password"));

            _cmd.ExecuteNonQuery();
            _con.Close();
        }

        /// <summary>
        /// Converts string to SQLvar
        /// </summary>
        /// <param name="str">string</param>
        /// <param name="sqlVar">@SQLvar</param>
        /// <returns></returns>
        private SqlParameter convertToSqlParam(string str, string sqlVar)
        {
            SqlParameter temp = new SqlParameter();
            temp.ParameterName = sqlVar;
            temp.SqlDbType = System.Data.SqlDbType.NVarChar;
            temp.Direction = System.Data.ParameterDirection.Input;
            temp.Value = str;
            return temp;
        }

        private void uxCustomerUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logscreen.Show();
        }

        /// <summary>
        /// THIS EVALUATES LOGINS SUCCESSFULLY BUT IT CAN BE MOVED TO LoginScreen.cs EVENTUALLY
        /// </summary>
        /// <param name="userEmail"></param>
        /// <param name="userPsw"></param>
        /// <returns></returns>
        public bool tryLogin(string userEmail, string userPsw)
        {
            _cmd.Parameters.Clear();
            _con.Open();
            _cmd.CommandType = System.Data.CommandType.StoredProcedure;
            _cmd.CommandText = "dbo.GetLogins";
            _cmd.Connection = _con;
            using (_reader = _cmd.ExecuteReader())
            {
                while (_reader.Read())
                {
                    string email = _reader["Email"].ToString();
                    string psw = _reader["Password"].ToString();
                    if (userEmail == email && userPsw == psw) { _con.Close(); return true; }
                }
            }
            _con.Close();
            return false;
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}

       