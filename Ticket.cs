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

    }
}
