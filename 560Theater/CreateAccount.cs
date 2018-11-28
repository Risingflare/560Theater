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
        // Will be used to enforce originality and write out
        const string connStr = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False";
        SqlConnection con = new SqlConnection(connStr);
        SqlDataReader _reader;
        SqlDataAdapter _update;

        public CreateAccount()
        {
            InitializeComponent();
        }

        // CREATE ACCOUNT BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(uxFNameTxtbox.Text) || String.IsNullOrEmpty(uxLastNameTxt.Text) || String.IsNullOrEmpty(uxEmailAddressTxt.Text) || String.IsNullOrEmpty(uxPasswordTxt.Text))
            {
                uxPasswordTxt.Clear();
                MessageBox.Show("Missing Fields Required");
            }
            // will also (1) test validity of email address and (2) write out to database
            else
            {
                //ShowTimeGUI showings = new ShowTimeGUI();
                //this.Hide();
                //showings.ShowDialog();
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        // private boolean isValid(string userEmail)

        // private boolean writeOutAcct(string first, string last, string email, string psw)

    }
}

       