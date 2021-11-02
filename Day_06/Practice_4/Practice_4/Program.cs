using System;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            printNumber(WordCount("How"));
        }

        static int WordCount(string input)
        {
            var result = input.Split();
            return result.Length;
        }

        static void printNumber(int num)
        {
            Console.WriteLine(num);
        }
    }
}
