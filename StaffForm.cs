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
    public partial class StaffForm : Form
    {
        public StaffForm(User user)
        {
            InitializeComponent();
            // load username
            username.Text = user.Username;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            // display ticketing as the first view
            reportUserControl1.Hide();
            ticketHistoryUserControl1.Hide();

            ticketingUserControl1.Show();
            ticketingUserControl1.BringToFront();
        }

        private void TicketingButton_Click(object sender, EventArgs e)
        {
            reportUserControl1.Hide();
            ticketHistoryUserControl1.Hide();

            ticketingUserControl1.Show();
            ticketingUserControl1.BringToFront();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            ticketingUserControl1.Hide();
            ticketHistoryUserControl1.Hide();

            reportUserControl1.Show();
            reportUserControl1.BringToFront();
        }

        private void TicketHistoryButton_Click(object sender, EventArgs e)
        {
            reportUserControl1.Hide();
            ticketingUserControl1.Hide();

            ticketHistoryUserControl1.Show();
            ticketHistoryUserControl1.BringToFront();
        }
    }
}
