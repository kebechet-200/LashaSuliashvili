using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    class IntMathOperation : IMathOperation<int>
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        public int Substract(int value1, int value2)
        {
            return value1 - value2;
        }
    }
}
