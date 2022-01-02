using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return new List<Ticket>();
        }

        public static void SaveTicket(Ticket ticket)
        {

        }

    }
}
