using System;

namespace Practice_2
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

            Console.WriteLine("Here's ur array in reversed order!");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            
        }
    }
}
