using System;

namespace Practice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array row size : ");
            int rowSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter array column size : ");
            int columnSize = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[rowSize, columnSize];
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Here's a matrix view of multidimentional array");
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    Console.Write($"{array[i,j]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
