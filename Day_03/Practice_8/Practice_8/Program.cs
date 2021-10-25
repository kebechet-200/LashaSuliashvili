using System;

namespace Practice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int inputNumber = int.Parse(Console.ReadLine());
            string output = "";
            for (int i = inputNumber; i > 0; i/=2)
            {
                output += (i % 2).ToString(); // 00001
            }
            //Console.WriteLine(output);
            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write($"{output[i]}");
            }
        }
    }
}
