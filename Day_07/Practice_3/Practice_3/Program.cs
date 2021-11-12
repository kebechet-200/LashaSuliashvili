using System;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CountDigits(input, 0));
        }

        static int CountDigits(int number, int counter)
        {
            if (number == 0) return counter;
            return CountDigits(number / 10, ++counter);
        }
    }
}
