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
    public partial class HistoryGUI : Form
    {
        private RemoveTicketHistoryDel removeHistHandler;
        public HistoryGUI(RemoveTicketHistoryDel removeTicket)
        {
            removeHistHandler = removeTicket;
            InitializeComponent();
        }

        private void uxHistoryRemoveSelected_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxHistoryListBox.SelectedItem == null) throw new Exception("Please select a value from the ticket history box to delete it");
                string ticket = uxHistoryListBox.SelectedItem.ToString();
                removeHistHandler(ticket);
            }
            catch(Exception execption)
            {
                MessageBox.Show(execption.Message);
            }
        }
    }
}
