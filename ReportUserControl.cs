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
    public partial class ReportUserControl : UserControl
    {
        public ReportUserControl()
        {
            InitializeComponent();
        }

        private void ReportUserControl_Load(object sender, EventArgs e)
        {
            DailyChartButton_Click(new object(), new EventArgs());

        }

        private void DailyChartButton_Click(object sender, EventArgs e)
        {

            // Calculate From today
            List<Ticket> tickets = Ticket.GetAvailableTickets();

            int totalVisitors= 0;
            int adult = 0;
            int child = 0;
            double income = 0.0;
            foreach(Ticket ticket in tickets)
            {
                if(ticket.Date.Equals(DateTime.Today.AddDays(-1)))
                {
                    totalVisitors += ticket.NoOfPeople;

                    if (ticket.Type == TicketType.CHILD)
                    {
                        child += ticket.NoOfPeople;
                    }
                    else
                    {
                        adult += ticket.NoOfPeople;
                    }

                    income += ticket.Price;
                }
            }
            // Show total adult and child users
            TicketsChart.Series[0].Points.Clear();
            TicketsChart.Series[0].Points.AddXY("Adult", adult);
            TicketsChart.Series[0].Points.AddXY("Child", child);
            visitorsLabel.Text = "Total Visitors: " + totalVisitors;
            incomeLabel.Text = "Total Income: " + income;
        }

        private void WeeklyChartButton_Click(object sender, EventArgs e)
        {
            List<Ticket> tickets = Ticket.GetAvailableTickets();
            int totalVisitors = 0;
            double income = 0.0;

            //days
            int sun = 0;
            int mon = 0;
            int tue = 0;
            int wed = 0;
            int thu = 0;
            int fri = 0;
            int sat = 0;

            foreach (Ticket ticket in tickets)
            {    
                if (IsThisWeek(ticket.Date))
                {
                    totalVisitors += ticket.NoOfPeople;
                    income += ticket.Price;

                    switch (ticket.Date.DayOfWeek.ToString())
                    {
                        case "Sunday":
                            sun += ticket.NoOfPeople;
                            break;

                        case "Monday":
                            mon += ticket.NoOfPeople;
                            break;
                        case "Tuesday":
                            tue += ticket.NoOfPeople;
                            break;
                        case "Wednesday":
                            wed += ticket.NoOfPeople;
                            break;
                        case "Thursday":
                            thu += ticket.NoOfPeople;
                            break;
                        case "Friday":
                            fri += ticket.NoOfPeople;
                            break;
                        case "Saturday":
                            sat += ticket.NoOfPeople;
                            break;

                    }

                }
            }
            TicketsChart.Series[0].Points.Clear();
            TicketsChart.Series[0].Points.AddXY("Monday", mon);
            TicketsChart.Series[0].Points.AddXY("Tuesday", tue);
            TicketsChart.Series[0].Points.AddXY("Wednesday", wed);
            TicketsChart.Series[0].Points.AddXY("Thursday", thu);
            TicketsChart.Series[0].Points.AddXY("Friday", fri);
            TicketsChart.Series[0].Points.AddXY("Saturday", sat);
            TicketsChart.Series[0].Points.AddXY("Sunday", sun);
            visitorsLabel.Text = "Total Visitors: " + totalVisitors;
            incomeLabel.Text = "Total Income: " + income;
        }
        private Boolean IsThisWeek(DateTime date)
        {
            if(date.DayOfYear <= DateTime.Today.DayOfYear && date.DayOfYear > (DateTime.Today.DayOfYear - 7))
            {
                return true;
            }
            return false;
        }
    }
}
