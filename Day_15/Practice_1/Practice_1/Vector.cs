using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class Vector
    {
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Vector operator -(Vector A, Vector B)
        {
            if (A.X < B.X || A.Y < B.Y || A.Z < B.Z)
                throw new Exception("Vector A's values should be greater than B's values");
            else
                return new Vector(A.X - B.X, A.Y - B.Y, A.Z - B.Z);
        }

        public static Vector operator +(Vector A, Vector B) => new Vector(A.X + B.X, A.Y + B.Y, A.Z + B.Z);

        public static Vector operator *(Vector A, Vector B) => new Vector(A.X * B.X, A.Y * B.Y, A.Z * B.Z);
    }
}
