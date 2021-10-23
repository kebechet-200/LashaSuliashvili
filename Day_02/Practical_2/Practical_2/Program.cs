using System;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number : ");
            int firstCorner = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int secondCorner = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number : ");
            int thirdCorner = int.Parse(Console.ReadLine());

            if ((firstCorner + secondCorner > thirdCorner) ||
                (secondCorner + thirdCorner > firstCorner) ||
                (thirdCorner + firstCorner > secondCorner))
            {
                Console.WriteLine("This could be a triangle!");
            }
            else
                Console.WriteLine("This couldn't be a triangle!");


        }
    }
}
