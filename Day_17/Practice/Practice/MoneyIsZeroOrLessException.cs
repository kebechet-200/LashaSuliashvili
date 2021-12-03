using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    [Serializable]
    public class MoneyIsZeroOrLessException : Exception
    {
        public MoneyIsZeroOrLessException(int quantity)
        : base(string.Format("The entered quantity: {0} is 0 or less", quantity)) { }
    }
}
