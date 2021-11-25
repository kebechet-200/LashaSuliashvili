using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    class Triangle
    {
        public Triangle(double a, double b, double c)
        {
            if ((a + b) > c &&
                (b + c) > a &&
                (c + a) > b)
            {
                A = a;
                B = b;
                C = c;
            }
            else Console.WriteLine("This is not valid triangle");
        }
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public double Perimeter()
        {
            return A + B + C;
        }

        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Triangle a, Triangle b)
        {
            return a.Area() == b.Area();
        }
        public static bool operator !=(Triangle a, Triangle b)
        {
            return a.Area() != b.Area();
        }
        public static bool operator >(Triangle a, Triangle b)
        {
            return a.Area() > b.Area();
        }
        public static bool operator <(Triangle a, Triangle b)
        {
            return a.Area() < b.Area();
        }

        public static Triangle operator +(Triangle a, Triangle b)
        {
            double twoSide = Math.Sqrt((a.Area() + b.Area()) * 2);
            return new Triangle(twoSide,twoSide,Math.Sqrt(Math.Pow(twoSide,2)+ Math.Pow(twoSide, 2)));
        }

        public static explicit operator Triangle(double a)
        {
            return new Triangle(a, a, a);
        }

    }
}
