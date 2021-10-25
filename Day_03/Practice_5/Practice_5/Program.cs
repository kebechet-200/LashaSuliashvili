using System;

namespace Practice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number of rows of Floyd's triangle to be printed: ");
            int zero = 0;
            int one = 1;
            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputNumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 1) Console.Write(zero);
                    else Console.Write(one);
                }
                Console.WriteLine();
            }
        }
    }
}
