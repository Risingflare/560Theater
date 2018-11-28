using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _560Theater
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        // CREATE ACCOUNT BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            if (uxFNameTxtbox == null || uxLastNameTxt == null || uxEmailAddressTxt == null || uxPasswordTxt == null)
            {
                uxPasswordTxt.Clear();
                MessageBox.Show("Missing Fields Required");
            }

        }



    }
}
