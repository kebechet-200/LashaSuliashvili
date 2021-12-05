using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    public class SearchByCity : GeneralSearch
    {
        public override void PrintInfo(string[] data, string searchBy)
        {
            if (data[0].ToLower() == searchBy.ToLower())
            {
                var sbc = Converter(data);
                Console.WriteLine($"{sbc.City}, {sbc.Area}, {sbc.Population}, {sbc.IsCapital}, {sbc.Country} ");
            }
        }
    }
}
