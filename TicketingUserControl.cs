using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace A2ZRecreation
{
    public partial class TicketingUserControl : UserControl
    {
        
        public TicketingUserControl()
        {
            InitializeComponent();
        }
        
        private void GenerateTicketButton_Click(object sender, EventArgs e)
        {
            
            // Get all available Tickets
            List<Ticket> tickets = Ticket.GetAvailableTickets();
            
            // Create the Ticket Object
            Ticket ticket = new Ticket();
            ticket.TicketId = tickets.Count;
            ticket.NoOfPeople = (int) NoOfPeople.Value;
            ticket.Date = DateTime.Today;
            ticket.Duration = DurationComboBox.SelectedIndex == 0 ? TicketDuration.ONE_HR 
                            : DurationComboBox.SelectedIndex == 1 ? TicketDuration.TWO_HR 
                            : DurationComboBox.SelectedIndex == 2 ? TicketDuration.FIVE_HR
                            : DurationComboBox.SelectedIndex == 3 ? TicketDuration.ONE_DAY
                            : TicketDuration.ONE_HR;

            ticket.Type = TicketTypeComboBox.SelectedIndex == 1 ? TicketType.CHILD: TicketType.REGULAR;
            ticket.Price = Ticket.CalculatePrice(ticket);

            // Display the ticket details
            MessageBox.Show(string.Format("Ticket Id: {0}\nNo Of People: {1}\nDate: {2}\nDuration: {3}\nType: {4}\nPrice: Rs {5}", ticket.TicketId, ticket.NoOfPeople, ticket.Date.ToLongDateString(), ticket.Duration, ticket.Type, ticket.Price), 
                "Ticket Details", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);

            // Add the ticket to the file
            Ticket.SaveTicket(ticket);
        }

        private void TicketingUserControl_Load(object sender, EventArgs e)
        {
            // Set current Day label
            DayLabel.Text += DateTime.Today.DayOfWeek.ToString();
        }

        

    }
}
