using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter pin: ");
            string pin = Console.ReadLine();
            IBan account = new DebitIban(pin);
            Console.Write("Welcome To ATM\nYou Have 3 options \n1.Withdraw\n2.Deposit\n3.Exit\nChoose one: ");
            int answer = int.Parse(Console.ReadLine());
            int quantity;
            switch (answer)
            {
                case 1:
                    try
                    {
                        Console.Write("Enter quantity: ");
                        quantity = int.Parse(Console.ReadLine());
                        account.Withdraw(quantity);
                    }
                    catch (UHaveNoEnoughMoneyException ex)
                    {
                        Console.WriteLine(ex.Message);
                        InnerExceptions.GetAllInnerExMessage(ex);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.Write("Enter quantity: ");
                        quantity = int.Parse(Console.ReadLine());
                        account.Deposit(quantity);
                    }
                    catch (MoneyIsZeroOrLessException ex)
                    {
                        Console.WriteLine(ex.Message);
                        InnerExceptions.GetLastInnerException(ex);

                    }
                    break;
                case 3:
                    break;
            }
        }
    }
}
