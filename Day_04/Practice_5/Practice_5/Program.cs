using System;

namespace Practice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size : ");
            int arrSize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arrSize];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter number of index {i} : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Unique elements of array are");

            int counter;
            for (int i = 0; i < array.Length; i++)
            {
                counter = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j]) counter++;
                }
                if (counter == 1) Console.WriteLine(array[i]);
            }
        }
    }
}
