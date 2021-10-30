using System;

namespace Practice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            char[] result = FullArray(size);
            CharMatching(result, 'a');
        }

        static char[] FullArray(int size)
        {
            char[] arr = new char[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter character for index {i}: ");
                arr[i] = Convert.ToChar(Console.ReadLine());
            }

            return arr;
        }

        static void CharMatching(char[] arr, char inputLetter)
        {
            int counter = 0;
            foreach (char letter in arr)
            {
                if (letter == inputLetter) counter++;
            }

            Console.WriteLine($"'{inputLetter}' is used {counter} times in that array");
        }
    }
}
