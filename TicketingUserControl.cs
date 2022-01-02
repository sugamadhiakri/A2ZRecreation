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
            //Generate500RandomTickets();
        }
        private void Generate500RandomTickets()
        {
            for (int i = 0; i <500; i++)
            {
                // Random Number generator
                Random random = new Random();
                // Get all available Tickets
                List<Ticket> tickets = Ticket.GetAvailableTickets();

                // Create the Ticket Object
                Ticket ticket = new Ticket();
                ticket.TicketId = tickets.Count;
                ticket.NoOfPeople = random.Next(1,16);
                ticket.Date = DateTime.Today.AddDays(-random.Next(7));
                int randomDuration = random.Next(4);
                ticket.Duration = randomDuration == 0 ? TicketDuration.ONE_HR
                                : randomDuration == 1 ? TicketDuration.TWO_HR
                                : randomDuration == 2 ? TicketDuration.FIVE_HR
                                : randomDuration == 3 ? TicketDuration.ONE_DAY
                                : TicketDuration.ONE_HR;
                int randomType = random.Next(2);
                ticket.Type = randomType == 1 ? TicketType.CHILD : TicketType.REGULAR;
                ticket.Price = CalculatePrice(ticket);

                // Add the ticket to the file
                Ticket.SaveTicket(ticket);
            }
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
            ticket.Price = CalculatePrice(ticket);

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
            DayLabel.Text = DayLabel.Text + DateTime.Today.DayOfWeek.ToString();
        }

        private static double CalculatePrice(Ticket ticket)
        {
            Rate currentRate = Rate.GetCurrentRates();

            // base price
            double price = ticket.Duration == TicketDuration.ONE_HR ? currentRate.OneHr
                         : ticket.Duration == TicketDuration.TWO_HR ? currentRate.TwoHr
                         : ticket.Duration == TicketDuration.FIVE_HR ? currentRate.FiveHr
                         : currentRate.OneDay;
            
            // price without discount
            price = price * ticket.NoOfPeople;

            // check for child discount
            if(ticket.Type == TicketType.CHILD)
            {
                price = price - price * currentRate.ChildDiscount / 100;
            }

            // check if eligible for group discount
            if(ticket.NoOfPeople >= 10)
            {
                price = price - price * currentRate.TenDiscount / 100;
            } else if (ticket.NoOfPeople >= 5)
            {
                price = price - price * currentRate.FiveDiscount/ 100;
            }

            // check if weekend charge is applicable
            if(DateTime.Today.DayOfWeek.Equals("Saturday") || DateTime.Today.DayOfWeek.Equals("Sunday"))
            {
                price = price + price * currentRate.WeekendCharge / 100;
            }

            return price;
        }

    }
}
