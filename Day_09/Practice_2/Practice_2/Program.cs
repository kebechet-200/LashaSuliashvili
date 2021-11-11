using System;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.Write("Enter side 1: ");
            triangle.First = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side 2: ");
            triangle.Second = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side 3: ");
            triangle.Third = Convert.ToInt32(Console.ReadLine());
            if (triangle.IsValidate())
            {
                Console.WriteLine($"Perimeter of the triangle is: {triangle.Perimeter()}");
                Console.WriteLine($"Area of the triangle is: {triangle.Area()}");
            }
            else Console.WriteLine("It is not valid triangle");
        }
        
    }
}
