using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 0; i <= 10; i++)
            {
                counter += i;
            }
            Console.WriteLine($"Sum from 0 to 10 is {counter}");
        }
    }
}
