using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    class MatrixMathOperation : IMathOperation<Matrix>
    {
        public Matrix Add(Matrix value1, Matrix value2)
        {
            return value1 + value2;
        }

        public Matrix Multiply(Matrix value1, Matrix value2)
        {
            return value1 * value2;
        }

        public Matrix Substract(Matrix value1, Matrix value2)
        {
            return value1 - value2;
        }
    }
}
