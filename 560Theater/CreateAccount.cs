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
    /// Creates new user account as long as a unique email (must not correspond to any email value in the [Customer] or [Admin] subtables of [User])
    /// Displays a message box if user fails to assign values to all 4 textboxes
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
        /// Evaluates originality of email
        /// Questions each tuple in the [Users] table by testing them for equality with a given email parameter
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
        /// Adds Account to [dbo].[Users] and its [dbo].[Customers] subtable
        /// Reports to database with Stored Procedure
        /// </summary>
        /// <param name="f">First Name</param>
        /// <param name="l">Last Name</param>
        /// <param name="e">Email</param>
        /// <param name="p">Password</param>
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

        /// <summary>
        /// State transition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCustomerUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logscreen.Show();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}

       