using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fill the matrix 2x2");
            Matrix m1 = new Matrix(
                Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()), 
                Convert.ToDouble(Console.ReadLine())
                );

            Console.WriteLine("Fill second matrix 2x2");
            Matrix m2 = new Matrix(
                Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine()),
                Convert.ToDouble(Console.ReadLine())
                );

            double p = m2;
            Matrix m3 = m1 + m2;
            Matrix m8 = m1;
            Matrix m4 = m1 - m2;
            Matrix m5 = m1 * m2;
            string tostring = m3.ToString();
            Console.WriteLine(m1.Equals(m8));
            Console.WriteLine(tostring);

        }
    }
}
