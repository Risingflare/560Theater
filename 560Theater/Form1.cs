﻿using System;
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
    public partial class uxCustomerUI : Form
    {
        public uxCustomerUI()
        {
            InitializeComponent();
        }

        private void uxHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will open the ticket history form.");
        }
    }
}
