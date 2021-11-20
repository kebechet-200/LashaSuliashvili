using System;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] arr = new Shape[3];
            Console.Write("Enter coordinates for A: ");
            Point p1 = new Point(Convert.ToInt32(Console.Read()), Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter coordinates for B: ");
            Point p2 = new Point(Convert.ToInt32(Console.Read()), Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter coordinates for C: ");
            Point p3 = new Point(Convert.ToInt32(Console.Read()), Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter coordinates for D: ");
            Point p4 = new Point(Convert.ToInt32(Console.Read()), Convert.ToInt32(Console.ReadLine()));
            arr[0] = new Rectangle(p1, p2, p3, p4);
            arr[0].Print();

            arr[1] = new Triangle(p1, p2, p3);
            arr[1].Print();

            arr[2] = new Circle(p1, p2);
            arr[2].Print();



        }
    }
}
