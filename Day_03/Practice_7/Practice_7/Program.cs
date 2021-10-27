using System;

namespace Practice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int inputNumber = int.Parse(Console.ReadLine());
            int first = 0, second = 1, main = 0;
            Console.Write($"{first} {second} "); // 0 1 
            for (int i = 2; i < inputNumber; i++)
            {
                main = first + second; // 1 , 2, 3, 5 ...
                Console.Write($"{main} "); // 1, 2, 3, 5 ... 
                first = second; // 1 , 1 , 2, ... 
                second = main; // 1 , 2, 3, ...
            }
        }
    }
}
