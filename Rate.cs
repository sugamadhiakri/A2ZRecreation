using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ZRecreation
{
    public class Rate
    {
        public int OneHr { get; set; }
        public int TwoHr { get; set; }
        public int FiveHr { get; set; }
        public int OneDay { get; set; }
        public int ChildDiscount { get; set; }
        public int FiveDiscount { get; set; }
        public int TenDiscount { get; set; }
        public int WeekendCharge { get; set; }

        public static Rate GetDefaultRates()
        {
            Rate defaultRate = new Rate();

            defaultRate.OneHr = 100;
            defaultRate.TwoHr = 180;
            defaultRate.FiveHr = 400;
            defaultRate.OneDay = 600;
            defaultRate.ChildDiscount = 10;
            defaultRate.FiveDiscount = 10;
            defaultRate.TenDiscount = 12;
            defaultRate.WeekendCharge = 20;

            return defaultRate;
        }
    }

    

}
