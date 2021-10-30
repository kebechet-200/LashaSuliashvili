using System;

namespace Practice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] result = FullArray(size);
            CalculateFact(result, 5);
        }

        static int[] FullArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter integer for index {i}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            return arr;
        }

        static void CalculateFact(int[] arr, int number)
        {
            int counter = 1;
            bool inArray = false;
            foreach (int item in arr)
            {
                if (number == item) inArray = true;
            }
            if (inArray)
            {
                for (int i = 1; i <= number; i++)
                {
                    counter *= i;
                }
                Console.WriteLine($"Factorial of {number} is {counter}");
            }
            else Console.WriteLine($"Number {number} was not found in the given array");
        }
    }
}
