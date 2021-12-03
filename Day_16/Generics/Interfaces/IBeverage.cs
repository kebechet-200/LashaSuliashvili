using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Interfaces
{
    public interface IBeverage
    {
        public int Strength { get; set; }
        public bool IsFairTrade { get; set; }
        int GetServingTemperature(bool includesMilk);
    }
}
