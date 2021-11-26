﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    class Matrix
    {
        private double[,] arr = new double[2, 2];
        public Matrix(double arr00, double arr01, double arr10, double arr11)
        {
            arr[0, 0] = arr00;
            arr[0, 1] = arr01;
            arr[1, 0] = arr10;
            arr[1, 1] = arr11;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            return new Matrix(m1.arr[0, 0] + m2.arr[0, 0], m1.arr[0, 1] + m2.arr[0, 1], m1.arr[1, 0] + m2.arr[1, 0], m1.arr[1, 1] + m2.arr[1, 1]);
        }
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            return new Matrix(m1.arr[0, 0] - m2.arr[0, 0], m1.arr[0, 1] - m2.arr[0, 1], m1.arr[1, 0] - m2.arr[1, 0], m1.arr[1, 1] - m2.arr[1, 1]);
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            return new Matrix(
                m1.arr[0, 0] * m2.arr[0, 0] + m1.arr[0, 1] * m2.arr[1, 0],
                m1.arr[0, 0] * m2.arr[0, 1] + m1.arr[0, 1] * m2.arr[1, 1],
                m1.arr[1, 0] * m2.arr[0, 0] + m1.arr[1, 1] * m2.arr[1, 0],
                m1.arr[1, 0] * m2.arr[0, 1] + m1.arr[1, 1] * m2.arr[1, 1]
                );
        }

        public override string ToString()
        {
            return $"arr[0,0] = {arr[0, 0]} arr[0,1] = {arr[0, 1]} arr[1,0] = {arr[1, 0]} arr[1,1] = {arr[1, 1]}";
        }
    }
}
