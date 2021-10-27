using System;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double inputNumber = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= inputNumber; i++)
                Console.WriteLine($"{i} cubed is {Math.Pow(i,3)}");
        }
    }
}
