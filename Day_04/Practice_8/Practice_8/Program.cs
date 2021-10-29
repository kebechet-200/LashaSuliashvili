using System;

namespace Practice_8
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * -- first approach using 2d array --  
             */

            int[,] someArray = new int[8, 8];
            
            // create first array matrix 8x8
            for (int i = 0; i < 8; i++)
            {
                for (int j = 7; j > i; j--)
                {
                    someArray[i, j] = 1;
                }
            }

            // print first array matrix
            Console.WriteLine("First Matrix");

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{someArray[i, j]}, ");
                }
                Console.WriteLine();
            }

            // modify matrics first part (0-3)
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8-i; j++)
                {
                    someArray[i, j] = 0;
                }
            }

            // modify matrics second part (4-7)
            int counter = 0;

            for (int i = 7; i > 3; i--)
            {
                for (int j = 7; j > counter; j--)
                {
                    someArray[i, j] = 1;
                }
                counter ++;
            }

            // print fully modified matrix
            Console.WriteLine("Second Matrix");

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{someArray[i, j]}, ");
                }
                Console.WriteLine();
            }



            /*
             * -- 2nd approach using jagged array --  
             */
            Console.WriteLine("Jagged array matrix");

            // create jagged array
            int[][,] jaggedArray = new int[8][,]
            {
                new int[1,8] {{0,1,1,1,1,1,1,1}},
                new int[1,8] {{0,0,1,1,1,1,1,1}},
                new int[1,8] {{0,0,0,1,1,1,1,1}},
                new int[1,8] {{0,0,0,0,1,1,1,1}},
                new int[1,8] {{0,0,0,0,0,1,1,1}},
                new int[1,8] {{0,0,0,0,0,0,1,1}},
                new int[1,8] {{0,0,0,0,0,0,0,1}},
                new int[1,8] {{0,0,0,0,0,0,0,0}}
            };

            // printing first face of matrix
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{jaggedArray[i][0, j]}, ");
                }
                Console.WriteLine();
            }

            // modify matrics first half (0-3)
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray.Length - i; j++)
                {
                    jaggedArray[i][0,j] = 0;
                }
            }

            // modify matrics second half (4-7)
            int counter2 = 0;

            for (int i = jaggedArray.Length - 1; i > (jaggedArray.Length - 1) / 2; i--)
            {
                for (int j = jaggedArray.Length - 1; j > counter2; j--)
                {
                    jaggedArray[i][0, j] = 1;
                }
                counter2++;
            }

            Console.WriteLine("Printing modified matrix");
            // printing modified matrix 
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{jaggedArray[i][0,j]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}
