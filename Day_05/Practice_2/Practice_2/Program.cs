using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //// implementation
            //int[] arr = { 17, 12512, 632, 6, 426, 12, 412, 4532, 5 };
            //int index = 6;
            //Sum(arr, index);
        }

        static void Sum(int[] arr, int index) 
        {
            int number = arr[index];
            int numberOfDigits = arr[index].ToString().Length;
            int sum = 0;

            for (int i = 0; i < numberOfDigits; i++)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine($"The sum of the digits of a number at index {index} is {sum}");
            
        }
    }
}
