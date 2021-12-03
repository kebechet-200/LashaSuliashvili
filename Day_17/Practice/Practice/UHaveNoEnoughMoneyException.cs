using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    [Serializable]
    public class UHaveNoEnoughMoneyException : Exception
    {
        public UHaveNoEnoughMoneyException(int quantity)
        : base(string.Format("The quantity you entered: {0} is more than your budget", quantity)) { }
    }
}
