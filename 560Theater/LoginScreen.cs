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
    public partial class uxLoginScreen : Form
    {
        /// <summary>
        /// Handles the login click.
        /// </summary>
        private LoginDel loginHandler;
        /// <summary>
        /// Intializes Login Screen
        /// </summary>
        /// <param name="login">The login delegate</param>
        public uxLoginScreen(LoginDel login)
        {
            loginHandler = login;
            InitializeComponent();
        }

        /// <summary>
        /// This property lets me transfer this form to my Customer view form.
        /// That way I can hide this will I'm in the customer screen. When I close the customer screen
        /// I can reactivate this.
        /// </summary>
        public uxLoginScreen LoginScreen { get => this;}
        
        /// <summary>
        /// Depending on the authentication values provided, we will either modify the runtime state and visibility or show an error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void uxLogin_Click(object sender, EventArgs e)
            {
                if (!uxCustomerRadioButton.Checked && !uxAdminRadioButton.Checked) MessageBox.Show("Please check the User or Admin button above");
                else if (String.IsNullOrWhiteSpace(uxEmailTextbox.Text) || String.IsNullOrWhiteSpace(uxPasswordBox.Text)) MessageBox.Show("Please enter an email and password");
                else
                {
                    bool isCustomer = uxCustomerRadioButton.Checked;
                    string email = uxEmailTextbox.Text;
                    string psw = uxPasswordBox.Text;
                    loginHandler(isCustomer, email, psw, this);
                    if (this.Visible.Equals(true)) MessageBox.Show("Invalid email or password");
                }
            }

        /// <summary>
        /// Transitions run-time state and modifies visibility
        /// </summary>
        private void uxCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount acctFrm = new CreateAccount(loginHandler,this);
            acctFrm.Show();
            this.Hide();
        }

        /// <summary>
        /// Clears all textboxs when visibility is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxLoginTextbox_VisibleChanged(object sender, EventArgs e)
        {
            uxEmailTextbox.Clear();
            uxPasswordBox.Clear();
        }

        /// <summary>
        /// Admin login info in documentation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxHelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refer to documentation for admin login\nCreate Account for customer login");
        }
    }
}

/* -- BACKUP --
private void uxLogin_Click(object sender, EventArgs e)
{
try
{
int number;
if (int.TryParse(uxLoginTextbox.Text, out number) == false) throw new Exception("Please enter a number in the box");
loginHandler(number, this.LoginScreen);
this.Hide();
}
catch (Exception excep)
{
MessageBox.Show(excep.Message);
}
} 
*/
/*const string connection = "Data Source=mssql.cs.ksu.edu;Initial Catalog=cis560_team04;Integrated Security=True;Encrypt=False";
string username = uxLoginTextbox.Text.Trim();
string password = uxPasswordBox.Text.Trim();

using (var conn = new SqlConnection(connection))
{
var cmd = new SqlCommand();
cmd.CommandType = System.Data.CommandType.StoredProcedure;
cmd.CommandText = "dbo.GetCustomers";
cmd.Connection = conn;
using (SqlDataReader dr = cmd.ExecuteReader())
{
while(dr.Read())
{
string n = dr["UserID"].ToString();

}
}
}*/
//if userid in admin or customer