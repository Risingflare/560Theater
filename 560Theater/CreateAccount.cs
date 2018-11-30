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
    public partial class CreateAccount : Form
    {

        const string connStr = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False";
        SqlConnection con = new SqlConnection(connStr);
        uxLoginScreen log;
        public CreateAccount(uxLoginScreen log)
        {
            this.log = log;
            InitializeComponent();
        }

        /// <summary>
        /// Shows the login screen when this form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCustomerUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        // CREATE ACCOUNT BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(uxFNameTxtbox.Text) || String.IsNullOrEmpty(uxLastNameTxt.Text) || String.IsNullOrEmpty(uxEmailAddressTxt.Text) || String.IsNullOrEmpty(uxPasswordTxt.Text))
            {
                MessageBox.Show("Missing Fields Required");
            }
            // (1) test validity (2) write out to database
            else
            {

            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void CreateAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Show();
        }

        // private boolean isValidEmail(string userEmail)

        // private boolean writeOutAccount(string first, string last, string email, string psw)

    }
}

       