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
    public partial class HistoryGUI : Form
    {
        private RemoveTicketHistoryDel removeHistHandler;
        private LoadTicketHistory loadticketHandler;
        int row;
        public HistoryGUI(RemoveTicketHistoryDel removeTicket, LoadTicketHistory loadticket)
        {
            loadticketHandler = loadticket;
            removeHistHandler = removeTicket;
            row = 0;
            InitializeComponent();
        }
        /// <summary>
        /// Removes selected ticket from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxHistoryRemoveSelected_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxHistoryListView.SelectedItems.Count < 1) throw new Exception("Please select a value from the ticket history box to delete it");
                int index = uxHistoryListView.SelectedIndices[0];
                uxHistoryListView.Items.Clear();
                removeHistHandler(index);
                row--;                
            }
            catch(Exception execption)
            {
                MessageBox.Show(execption.Message);
            }
            
        }
        public void UpdateTicketListView(string ticket)
        {
            string[] split = ticket.Split(',');
            ListViewItem item = new ListViewItem(split[0], row);
            item.SubItems.Add(split[1]);
            item.SubItems.Add(split[2]);
            item.SubItems.Add(split[3]);
            item.SubItems.Add(split[4]);
            item.SubItems.Add(split[5]);
            uxHistoryListView.Items.Add(item);
            uxHistoryListView.Update();
            row++;
        }

        private void HistoryGUI_Load(object sender, EventArgs e)
        {
            loadticketHandler();
        }
    }
}
