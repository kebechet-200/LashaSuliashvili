using System;

namespace Practical_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The pow of the entered number is {number*number}");
        }
    }
}
