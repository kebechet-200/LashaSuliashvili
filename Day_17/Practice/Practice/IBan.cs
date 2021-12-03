using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public abstract class IBan
    {
        private int _budget = 1000;

        public IBan(string pIN)
        {
            while (pIN.Length != 4) Console.WriteLine("Enter correct pin");
            PIN = pIN;
        }

        public string PIN { get; private set; }
        public string Owner { get; set; }
        public int IdNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void Deposit(int quantity)
        {
            if (quantity > 0)
            {
                _budget += quantity;
                Console.WriteLine($"It performed well , the budget is : {_budget}");
            }
            else
            {
                throw new MoneyIsZeroOrLessException(quantity);
            }
        }
        public void Withdraw(int quantity)
        {
            if (_budget >= quantity) 
            {
                _budget -= quantity;
                Console.WriteLine($"It performed well. the budget is : {_budget}");
            } 
            else
            {
                throw new UHaveNoEnoughMoneyException(quantity);
            } 
        }
    }
}
