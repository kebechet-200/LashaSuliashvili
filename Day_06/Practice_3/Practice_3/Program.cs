using System;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            AddSpace("Goodbye World");
        }

        static void AddSpace(string input)
        {
            for (int i = 1; i < input.Length; i+=2)
            {
                input = input.Insert(i, " ");
            }
            Console.WriteLine(input);
        }
    }
}
