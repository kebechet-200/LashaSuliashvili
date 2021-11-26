using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public interface IMathOperation<T>
    {
        public T Add(T value1, T value2);
        public T Substract(T value1, T value2);
        public T Multiply(T value1, T value2);
    }
}
