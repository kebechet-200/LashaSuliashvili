using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    public class SearchByCountry : GeneralSearch
    {
        public override void PrintInfo(string[] data, string searchBy)
        {
            List<string> cities = new List<string>();
            if (data[data.Length - 1].ToLower() == searchBy.ToLower())
            {
                if (data[3] == "true") cities.Add($"{data[0]} (IsCapital)");
                else cities.Add(data[0]);
                var sbc = Converter(data);
                StringBuilder sb = new StringBuilder();
                sb.Append($"{sbc.Country}, ");
                sb.Append($"{sbc.Area}, ");
                sb.Append($"{sbc.Population}, ");
                foreach (var item in cities)
                    sb.Append($"{item}, ");
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
