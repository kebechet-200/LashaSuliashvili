using Generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Compare
{
    class Tea : IBeverage
    {
        public int Strength { get; set; }
        public bool IsFairTrade { get; set; }
        public string MeErrorUndaWarmovqmna { get; set; }

        public int GetServingTemperature(bool includesMilk)
        {
            throw new NotImplementedException();
        }
    }
}
