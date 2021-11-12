using System;

namespace Practice_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input degree: ");
            int degree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Power(number, degree));
        }

        static int Power(int number, int degree)
        {
            if (degree == 0) return 1;
            else number *= Power(number, degree - 1);
            return number;
        }
    }
}
