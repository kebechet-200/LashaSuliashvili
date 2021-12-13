using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    public abstract class GeneralSearch
    {
        private static GeneralSearch sbc = new SearchByCity();
        public string City { get; set; }
        public float Area { get; set; }
        public float Population { get; set; }
        public bool IsCapital { get; set; }
        public string Country { get; set; }

        public virtual void PrintInfo(string[] data, string searchBy) { }
        public static string[] Parse(string data)
        {
            string[] parts = data.Split('|');
            string[] converter = { parts[0], parts[1], parts[2], parts[3], parts[4] };
            return converter;
        }

        public static GeneralSearch Converter(string[] separatedData)
        {
            sbc.City = separatedData[0];
            sbc.Area = float.Parse(separatedData[1]);
            sbc.Population = float.Parse(separatedData[2]);
            sbc.IsCapital = bool.Parse(separatedData[3]);
            sbc.Country = separatedData[4];
            return sbc;
        }
    }
}
