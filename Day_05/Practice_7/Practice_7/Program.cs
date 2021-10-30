using System;

namespace Practice_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter count of rows: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter count of columns: ");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] firstArray2d = Array2d(row, column);
            int[,] secondArray2d = Array2d(row, column);
            int[,] sumOfMatrix = SumOfMatrices(firstArray2d, secondArray2d);
            PrintMatrix(sumOfMatrix);
        }

        static int[,] Array2d(int row, int column)
        {
            Console.WriteLine("===============================");
            int[,] arr = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"Enter integer for index {i},{j}: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            return arr;
        }

        static int[,] SumOfMatrices(int[,] firstArray, int[,] secondArray)
        {
            int[,] sumArray = new int[firstArray.GetLength(0), firstArray.GetLength(1)];

            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < firstArray.GetLength(1); j++)
                {
                    sumArray[i, j] = firstArray[i, j] + secondArray[i, j];
                }
            }

            return sumArray;
        }

        static void PrintMatrix(int[,] arr)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("Here is sum of matrices");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]}, ");
                }
                Console.WriteLine();
            }
        }


    }
}
