using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarr = new int[5] { 1, 2, 3, 4, 5 };
            int index = 4;
            int number = returnElement(myarr, index);

            Console.WriteLine($"Number at index {index} in the array is {number}");
        }

        static int returnElement(int[] array, int index)
        {
            return array[index];
        }
    }
}
