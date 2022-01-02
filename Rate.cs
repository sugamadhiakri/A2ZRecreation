﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ZRecreation
{
    public class Rate
    {
        public double OneHr { get; set; }
        public double TwoHr { get; set; }
        public double FiveHr { get; set; }
        public double OneDay { get; set; }
        public double ChildDiscount { get; set; }
        public double FiveDiscount { get; set; }
        public double TenDiscount { get; set; }
        public double WeekendCharge { get; set; }

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