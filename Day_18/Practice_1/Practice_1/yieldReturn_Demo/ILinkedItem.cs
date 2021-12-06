using System;
using System.Collections.Generic;
using System.Text;
using yieldReturn_Demo;

namespace yieldReturn_Demo
{
    public interface ILinkedItem<T> : IEnumerable<T>
    {
        void AddItem(T value);
        bool Exists();
        void RemoveItem(T data);
        void PrintItems();

        T this[int index] { get; set; }
    }
}
