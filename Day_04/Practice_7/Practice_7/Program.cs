using System;

namespace Practice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array row size : ");
            int rowSize = Convert.ToInt32(Console.ReadLine()); // array's row
            Console.Write("Enter array column size : ");
            int columnSize = Convert.ToInt32(Console.ReadLine()); // arrays column

            int[,] array = new int[rowSize, columnSize]; //first matrix
            int[,] secondArray = new int[rowSize, columnSize]; //second matrix

            Console.WriteLine("Fill first matrix");

            // fill matrices
            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Fill second matrix");

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    Console.Write($"Enter number for index {i},{j}: ");
                    secondArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Here is sum of two matrices");

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    Console.Write($"{array[i,j] + secondArray[i,j]}, ");
                }
                Console.WriteLine();
            }

        }
    }
}
