using System;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= inputNumber; i+=2)
            {
                counter += i;
            }
            Console.WriteLine($"sum of odd numbers from 1 to {inputNumber} is {counter}");
        }
    }
}
