using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class CoffeeComparable : Coffee, IComparable
    {
        public int CompareTo(object obj)
        {
            Coffee coffee2 = obj as Coffee;
            return string.Compare(Variety, coffee2.Variety);
        }
    }
}
