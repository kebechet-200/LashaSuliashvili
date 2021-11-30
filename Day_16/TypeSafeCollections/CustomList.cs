using System;
using System.Collections.Generic;
using System.Text;

namespace TypeSafeCollections
{
    public class CustomList<T>
    {
        private List<T> customList = new List<T>();
        public T this[int index]
        {
            get
            {
                return customList[index];
            }
            set
            {
                customList[index] = value;
            }
        }
        
        public void Add(T item)
        {
            customList.Add(item);
        }
        public void Remove(T item)
        {
            customList.Remove(item);
        }
    }
}
