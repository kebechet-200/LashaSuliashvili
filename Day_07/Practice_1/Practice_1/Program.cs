using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            PrintNumberTail(input);
            Console.WriteLine();
            PrintNumberNoTail(input);
        }

        static void PrintNumberTail(int number)
        {
            if (number <= 0) return;
            Console.Write(number + " ");
            PrintNumberTail(number - 1);
        }

        static void PrintNumberNoTail(int number)
        {
            if (number <= 0) return;
            PrintNumberNoTail(number - 1);
            Console.Write(number + " ");
        }

        
    }
}
