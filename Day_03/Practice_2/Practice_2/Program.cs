using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int inputNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= inputNumber; i++)
            {
                counter += i;
            }
            Console.WriteLine($"Sum from 1 to {inputNumber} is {counter}");
        }
    }
}
