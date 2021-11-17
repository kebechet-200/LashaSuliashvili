using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    class Circle : Shape
    {
        public Circle(Point center, Point circlepoint)
        {
            Center = center;
            CirclePoint = circlepoint;
        }
        public Point Center { get; set; }
        public Point CirclePoint { get; set; }

        public override void Print()
        {
            
            Console.WriteLine($"Area of the circle is {Area()}");
            Console.WriteLine($"Perimeter of the circle is {Perimeter()}");
        }
        protected override double Area()
        {
            double _powerRadius = (CirclePoint.X - Center.X) * 2 + (CirclePoint.Y - Center.Y) * 2;
            return Math.PI * _powerRadius;
        }

        protected override double Perimeter()
        {
            double _powerRadius = (CirclePoint.X - Center.X) * 2 + (CirclePoint.Y - Center.Y) * 2;
            return 2 * Math.PI * Math.Floor(_powerRadius);
        }
    }
}
