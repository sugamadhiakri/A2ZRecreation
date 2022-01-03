using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace A2ZRecreation
{
    public enum TicketType
    {
        REGULAR,
        CHILD
    }

    public enum TicketDuration
    {
        ONE_HR,
        TWO_HR,
        FIVE_HR,
        ONE_DAY
    }

    public class Ticket
    {
        public int TicketId { get; set; }
        public int NoOfPeople { get; set; }
        public TicketDuration Duration { get; set; }
        public TicketType Type { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }

        public static List<Ticket> GetAvailableTickets ()
        {
            FileStream ticketingFile;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Ticket>));
            List<Ticket> tickets;
            // Check if Ticket.xml already exist or not
            try
            {
                ticketingFile = new FileStream(System.IO.Directory.GetCurrentDirectory() + "\\Ticket.xml", FileMode.Open, FileAccess.Read);
                tickets = (List<Ticket>)serializer.Deserialize(ticketingFile);
                ticketingFile.Close();
            } catch (Exception err) // Ticket.xml doesn't exist
            {
                // create the Ticket.xml file
                ticketingFile = new FileStream(System.IO.Directory.GetCurrentDirectory() + "\\Ticket.xml", FileMode.Create, FileAccess.Write);
                tickets = new List<Ticket>();
                serializer.Serialize(ticketingFile, tickets);
                ticketingFile.Close();
            }

            return tickets;
        }

        public static void SaveTicket(Ticket ticket)
        {
            List<Ticket> tickets = GetAvailableTickets();
            tickets.Add(ticket);

            FileStream ticketingFile = new FileStream(System.IO.Directory.GetCurrentDirectory() + "\\Ticket.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Ticket>));
            ticketingFile.SetLength(0);
            serializer.Serialize(ticketingFile, tickets);
            ticketingFile.Close();
        }

        public static void GenerateRandomTickets()
        {
            for (int i = 0; i < 100; i++)
            {
                // Random Number generator
                Random random = new Random();
                // Get all available Tickets
                List<Ticket> tickets = Ticket.GetAvailableTickets();

                // Create the Ticket Object
                Ticket ticket = new Ticket();
                ticket.TicketId = tickets.Count;
                ticket.NoOfPeople = random.Next(1, 16);
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
                SaveTicket(ticket);
            }
        }

        public  static double CalculatePrice(Ticket ticket)
        {
            Rate currentRate = Rate.GetCurrentRates();

            // base price
            double price = ticket.Duration == TicketDuration.ONE_HR ? currentRate.OneHr
                         : ticket.Duration == TicketDuration.TWO_HR ? currentRate.TwoHr
                         : ticket.Duration == TicketDuration.FIVE_HR ? currentRate.FiveHr
                         : currentRate.OneDay;

            // price without discount
            price *= ticket.NoOfPeople;

            // check for child discount
            if (ticket.Type == TicketType.CHILD)
            {
                price -= price * currentRate.ChildDiscount / 100;
            }

            // check if eligible for group discount
            if (ticket.NoOfPeople >= 10)
            {
                price -= price * currentRate.TenDiscount / 100;
            }
            else if (ticket.NoOfPeople >= 5)
            {
                price -= price * currentRate.FiveDiscount / 100;
            }

            // check if weekend charge is applicable
            if (DateTime.Today.DayOfWeek.Equals("Saturday") || DateTime.Today.DayOfWeek.Equals("Sunday"))
            {
                price += price * currentRate.WeekendCharge / 100;
            }

            return price;
        }

    }
}
