using System;

namespace Practical_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number : ");

            int result = int.Parse(Console.ReadLine());

            if (result % 2 == 0)
                Console.WriteLine($"Entered number {result} is even");
            
            else
                Console.WriteLine($"Entered number {result} is odd");
        }
    }
}
