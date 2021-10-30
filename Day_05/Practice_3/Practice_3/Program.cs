using System;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] result = reversedArray(size);
            MinMax(result);
        }

        static int[] reversedArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter integer for index {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] reversedArr = new int[size];
            int j = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                reversedArr[j] = arr[i];
                j++;
            }
            return reversedArr;
        }

        static void MinMax(int[] arr)
        {
            int min = arr[0], max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            Console.WriteLine($"The minimum number in the array is {min}");
            Console.WriteLine($"The maximum number in the array is {max}");
        }
    }
}
