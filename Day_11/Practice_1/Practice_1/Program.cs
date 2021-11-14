using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // first
            Console.WriteLine("Using MATH.Pow Function");
            Console.WriteLine("-----------------------");
            Console.Write("Enter a base number: ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());
            string result;
            double pow = MATH.Pow(baseNumber, exponent, out result);

            if (result == Statusses.Success.ToString()) Console.WriteLine(pow);
            else Console.WriteLine(result);

            // second
            Console.WriteLine();
            Console.WriteLine("Using MATH.Min Function");
            Console.WriteLine("-----------------------");
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            string checkerMin;
            int min = MATH.Min(a, b, out checkerMin);
            if (checkerMin == Statusses.Success.ToString()) Console.WriteLine(min);
            else Console.WriteLine(checkerMin);

            //third
            Console.WriteLine();
            Console.WriteLine("Using MATH.Max Function");
            Console.WriteLine("-----------------------");
            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            string checkerMax;
            int max = MATH.Max(a, b, out checkerMax);
            if (checkerMax == Statusses.Success.ToString()) Console.WriteLine(max);
            else Console.WriteLine(checkerMax);
        }
    }
}
