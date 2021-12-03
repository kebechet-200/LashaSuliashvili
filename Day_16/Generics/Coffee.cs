using Generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Coffee : IBeverage
    {
        public double AverageRating { get; set; }
        public string Variety { get; set; }
        public int Strength { get; set; }
        public bool IsFairTrade { get; set; }
        int ServingTempWithoutMilk { get; set; }
        int ServingTempWithMilk { get; set; }

        public int GetServingTemperature(bool includesMilk)
        {
            if (includesMilk)
                return ServingTempWithMilk;
            else
                return ServingTempWithoutMilk;
        }
    }
}