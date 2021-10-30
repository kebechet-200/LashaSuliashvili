using System;

namespace Practice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = InputNumber();
            Calculate(result);
        }

        static double InputNumber()
        {
            Console.Write("Enter a positive number: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        static void Calculate(double number)
        {
            string printNumber = $"{number} = ";
            for (int i = number.ToString().Length - 1; i >= 0; i--)
            {
                printNumber += $"{Math.Floor(number / Math.Pow(10, i))} * 10^{i} ";
                if (i != 0) printNumber += "+ ";
                number %= Math.Pow(10, i);
            }
            Console.WriteLine(printNumber);
        }
    }
}
