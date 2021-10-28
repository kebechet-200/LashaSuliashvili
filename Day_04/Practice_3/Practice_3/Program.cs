using System;

namespace Practice_3
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

            int counter = 0;

            foreach (int number in array)
            {
                counter += number;
            }

            Console.WriteLine($"sum of array elements is {counter}");
        }
    }
}
