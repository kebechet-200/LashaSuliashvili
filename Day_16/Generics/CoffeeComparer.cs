using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Generics
{
    class CoffeeComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Coffee coffee1 = x as Coffee;
            Coffee coffee2 = y as Coffee;
            double rating1 = coffee1.AverageRating;
            double rating2 = coffee2.AverageRating;
            return rating1.CompareTo(rating2);
        }
    }
}
