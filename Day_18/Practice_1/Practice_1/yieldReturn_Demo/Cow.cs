using System.Collections.Generic;

namespace yieldReturn_Demo
{
    public class Cow
    {
        public Cow(int d, string n)
        {
            DaysOflife = d;
            Name = n;
        }
        public int DaysOflife { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Day: {DaysOflife}, Name: {Name}";
        }

        public IEnumerable<string> Colour
        {
            get
            {
                yield return "brown";
                yield return "black";
                yield return "white";
            }
        }
    }
}