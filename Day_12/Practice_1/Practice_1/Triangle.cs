using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class Triangle : Shape
    {
        
        public Triangle(Point a, Point b, Point c)
        {
            FirstSide = a;
            SecondSide = b;
            ThirdSide = c;
        }
        public Point FirstSide { get; set; }
        public Point SecondSide { get; set; }
        public Point ThirdSide { get; set; }

        public override void Print()
        {    
            Console.WriteLine($"Area of triangle is {Area()}");
            Console.WriteLine($"Perimeter of triangle is {Perimeter()}");
        }

        protected override double Area()
        {
            double first = (SecondSide.X - FirstSide.X) * 2 + (SecondSide.Y - FirstSide.Y) * 2;
            double second = (ThirdSide.X - SecondSide.X) * 2 + (ThirdSide.Y - SecondSide.Y) * 2;
            double third = (FirstSide.X - ThirdSide.X) * 2 + (FirstSide.Y - ThirdSide.Y) * 2;
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - first) * (s - second) * (s - third));
        }

        protected override double Perimeter()
        {
            double first = (SecondSide.X - FirstSide.X) * 2 + (SecondSide.Y - FirstSide.Y) * 2;
            double second = (ThirdSide.X - SecondSide.X) * 2 + (ThirdSide.Y - SecondSide.Y) * 2;
            double third = (FirstSide.X - ThirdSide.X) * 2 + (FirstSide.Y - ThirdSide.Y) * 2;
            return first + second + third;
        }
    }
}
