using System;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] result = fullArray(size);
            Average(result);
        }

        static int[] fullArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter integer for index {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            return arr;
        }

        static void Average(int[] arr)
        {
            double sum = 0;
            foreach (int number in arr)
            {
                sum += number;
            }
            double average = Math.Round(sum / arr.Length,2);
            Console.WriteLine($"Arithmetic average of array is {average}");
        }
    }
}
