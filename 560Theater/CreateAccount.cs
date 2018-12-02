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

        private const string connStr = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False";
        private SqlConnection con = new SqlConnection(connStr);

        private LoginDel _logDel;
        private uxLoginScreen _log;

        private string _fname;
        private string _lname;
        private string _email;
        private string _psw;
        private bool _validAuth;

        /// <summary>
        /// Receives parameters from LoginScreen
        /// </summary>
        /// <param name="logdel"></param>
        /// <param name="log"></param>
        public CreateAccount(LoginDel logdel, uxLoginScreen log)
        {
            _logDel = logdel;
            _log = log;
            _validAuth = false;
            InitializeComponent();
        }

        /// <summary>
        /// Create Account Button
        /// Enforces (1) originality of email, (2) all fields are satisfied appropriately
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            _fname = uxFNameTxtbox.Text;
            _lname = uxLastNameTxt.Text;
            _email = uxEmailAddressTxt.Text;
            _psw = uxPasswordTxt.Text;
            if (String.IsNullOrEmpty(_fname) || String.IsNullOrEmpty(_lname) || String.IsNullOrEmpty(_email) || String.IsNullOrEmpty(_psw))
            {
                MessageBox.Show("Missing Fields Required");
            }
            else if (!isValidEmail(_email))
            {
                MessageBox.Show("The email entered is associated with an existing account");
                uxEmailAddressTxt.Text = "";
                uxPasswordTxt.Text = "";
            }
            else
            {
                writeOutAccount();
                _validAuth = true;
                this.Hide();
                _logDel(2, _log);
            }
        }

        

        private void CreateAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!_validAuth) _log.Show();
        }

        private bool isValidEmail(string userEmail)
        {
            // evaluates equality
            return true;
        }

        private void writeOutAccount()
        {
            // passes the _fields into the database as attributes to an object (row)
        }

        private void uxCustomerUI_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

    }
}

       