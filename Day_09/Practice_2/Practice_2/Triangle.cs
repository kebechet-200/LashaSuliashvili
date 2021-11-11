using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
{
    class Triangle
    {
        private int a;
        private int b;
        private int c;
        private bool isValidate = false;

        public int First
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public int Second
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public int Third
        {
            get
            {
                return c;
            }
            set
            {
                c = value;

                if ((a + b) > c &&
                (b + c) > a &&
                (c + a) > b)
                {
                    isValidate = true;
                }
            }
        }

        public int Perimeter()
        {
            return a + b + c;
        }

        public double Area()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); 
        }

        public bool IsValidate()
        {
            if (isValidate)
            {
                return true;
            }
            else return false;
        }

        //public void IsValidate()
        //{
        //    if (
        //        (a + b) > c &&
        //        (b + c) > a &&
        //        (c + a) > b)
        //    {
        //        Console.WriteLine($"Perimeter of the triangle is: {Perimeter()}");
        //        Console.WriteLine($"Area of the triangle is: {Area()}");
        //    }
        //    else Console.WriteLine("It is not valid triangle"); ;
        //}
    }
}
