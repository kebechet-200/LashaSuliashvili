using System;

namespace Practice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write($"divisors of {inputNumber} are: ");
            for (int i = 1; i <= inputNumber; i++)
            {
                if (inputNumber % i == 0) Console.Write($"{i} ");
            }
        }
    }
}
