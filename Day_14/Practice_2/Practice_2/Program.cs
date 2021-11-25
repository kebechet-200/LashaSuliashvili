using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter first angle: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter second angle: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter third angle: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, c);
            Triangle triangle1 = new Triangle(4, 5, 6);
            Console.WriteLine(triangle.Area());
            Console.WriteLine(triangle.Perimeter());
            Console.WriteLine(triangle > triangle1);
            Console.WriteLine(triangle < triangle1);
            Console.WriteLine(triangle == triangle1);
            Console.WriteLine(triangle != triangle1);
            Console.WriteLine(triangle + triangle1);
            double angle = 8;
            Triangle triangle2 = (Triangle)angle;

        }
    }
}
