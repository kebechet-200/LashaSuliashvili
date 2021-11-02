using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Reversed("Hello");
        }

        static void Reversed(string input)
        {
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
    }
}
