using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2ZRecreation
{
    public partial class TicketHistoryUserControl : UserControl
    {
        public TicketHistoryUserControl()
        {
            InitializeComponent();
            TicketHistoryTable.DataSource = Ticket.GetAvailableTickets();
        }

        private void TicketHistoryUserControl_Load(object sender, EventArgs e)
        {
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            TicketHistoryTable.DataSource = Ticket.GetAvailableTickets();
        }

        private void RandomTicketsGenerator_Click(object sender, EventArgs e)
        {
            Ticket.GenerateRandomTickets();
            TicketHistoryTable.DataSource = Ticket.GetAvailableTickets();
        }
    }
}
