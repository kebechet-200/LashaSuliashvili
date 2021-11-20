using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    class Rectangle : Shape
    {
        public Rectangle(Point a, Point b, Point c, Point d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }

        protected override double Area()
        {
            return B.X - C.X * B.Y - A.Y;
        }

        public override void Print()
        {
            Console.WriteLine($"Area of the rectangle is {Area()}");
            Console.WriteLine($"Perimeter of the rectangle is {Perimeter()}");
        }

        protected override double Perimeter()
        {
            return (B.Y - A.Y + B.X - C.X) * 2;
        }
    }
}
