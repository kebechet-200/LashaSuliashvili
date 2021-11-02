using System;

namespace Practice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello 1 !";
            int letters = returnLettersCount(input);
            int digits = returnNumberCount(input);
            PrintResult(letters, digits, input);
        }

        static int returnLettersCount(string input)
        {
            int counter = 0;
            foreach (char character in input)
            {
                if (char.IsLetter(character))
                {
                    counter++;
                }
            }

            return counter;
        }

        static int returnNumberCount(string input)
        {
            int counter = 0;
            foreach (char character in input)
            {
                if (char.IsDigit(character))
                {
                    counter++;
                }
            }

            return counter;
        }

        static void PrintResult(int letterCount, int digitCount, string input)
        {
            Console.WriteLine($"\"{input}\" -> Letters: {letterCount}, Numbers: {digitCount}, Others: {input.Length - (letterCount + digitCount)}");
        }
    }
}
