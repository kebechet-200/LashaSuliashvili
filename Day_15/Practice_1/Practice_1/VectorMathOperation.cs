using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class VectorMathOperation : IMathOperation<Vector>
    {
        public Vector Add(Vector value1, Vector value2)
        {
            return value1 + value2;
        }

        public Vector Multiply(Vector value1, Vector value2)
        {
            return value1 * value2;
        }

        public Vector Substract(Vector value1, Vector value2)
        {
            return value1 - value2;
        }
    }
}
