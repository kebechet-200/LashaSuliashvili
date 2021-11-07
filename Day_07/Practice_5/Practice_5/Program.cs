using System;

namespace Practice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input text: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Is palindrome? {IsPalindrome(input)}");
        }

        static bool IsPalindrome(string input)
        {
            if (input.Length < 2) return true;
            if (input[input.Length - 1] != input[0]) return false;
            else return IsPalindrome(input.Substring(1, input.Length - 2));
        }
    }
}
