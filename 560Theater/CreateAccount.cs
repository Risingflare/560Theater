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
    /// Creates new account and writes out to database
    ///     --[WRITING OUT INCOMPLETE]--
    /// </summary>
    public partial class CreateAccount : Form
    {

        private const string _connStr = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False";
        SqlConnection _con = new SqlConnection(_connStr);
        SqlCommand _cmd = new SqlCommand();
        SqlDataReader _reader;
        
        private LoginDel _logdel;
        uxLoginScreen _logscreen;

        private string _fname = ""; // need fields?
        private string _lname = "";
        private string _email = "";
        private string _psw = "";

        /// <summary>
        /// Receives parameters from LoginScreen
        /// </summary>
        /// <param name="logdel"></param>
        /// <param name="log"></param>
        public CreateAccount(LoginDel log, uxLoginScreen screen)
        {
            _logdel = log;
            _logscreen = screen;
            InitializeComponent();
            // updateUserList() ?
        }

        /// <summary>
        /// Create Account Button
        /// Enforces (1) originality of email, (2) fields are full
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCreateAccountButton_Click(object sender, EventArgs e)
        {
            _fname = uxFNameTxtbox.Text;
            _lname = uxLastNameTxt.Text;
            _email = uxEmailAddressTxt.Text;
            _psw = uxPasswordTxt.Text;
            if (String.IsNullOrWhiteSpace(_fname) || String.IsNullOrWhiteSpace(_lname) || String.IsNullOrWhiteSpace(_email) || String.IsNullOrWhiteSpace(_psw))
            {
                MessageBox.Show("Missing Fields Required");
            }
            else if (!isValidEmail(_email))
            {
                MessageBox.Show(_email + " is associated with existing account.");
            }
            else
            {
                writeOutAccount();
                this.Hide();
                _logdel(2, _logscreen);
            }
        }

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
                    if (userEmail == email) return false;
                 }
             }
             _con.Close();
            return true;
        }

        private void writeOutAccount()
        {
            // passes the _fields into the database as attributes to an object (row)
            _cmd.Parameters.Clear();
            _con.Open();
            _cmd.CommandType = System.Data.CommandType.StoredProcedure;
            _cmd.CommandText = "dbo.AddAccount";
            _cmd.Connection = _con;
            SqlParameter f = convertToSqlParam(_fname, "@FirstName");
            _cmd.Parameters.Add(f);
            SqlParameter l = convertToSqlParam(_lname, "@LastName");
            _cmd.Parameters.Add(l);
            SqlParameter e = convertToSqlParam(_email, "@Email");
            _cmd.Parameters.Add(e);
            SqlParameter p = convertToSqlParam(_psw, "@Password");
            _cmd.Parameters.Add(p);

            _cmd.ExecuteNonQuery();
            _con.Close();
        }

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

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}

       