using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Exam3_Practice.CustomList
{
    public class MyList<T> : IEnumerable
    {

        
        private static int _count = 100;
        private T[] _collection = new T[_count];
        private static int _index = 0;

        public int Count { get; private set; } = _count;

        public T this[int index]
        {
            get
            {
                return _collection[index];
            }
            set
            {
                _collection[index] = value;
            }
        }
        public void Add(T item)
        {
            _collection[_index] = item;
            ++_index;
        }

        public void AddRange(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                _collection[_index] = item;
                ++_index; // es ar momwons :D
            }
        }

        //public void Remove(T item)
        //{
        //    for (int i = 0; i < _count; i++)
        //    {
        //        if (_collection[i].Equals(item))
        //        {
        //            _collection.
        //        }
        //    }
        //}

        public bool Contains(T item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_collection[i].Equals(item))
                    return true;
            }
            return false;
        }

        public T Single(IEnumerable<T> source, T item)
        {
            int counter = 0;

            for (int i = 0; i < _count; i++)
            {
                if (_collection[_index].Equals(item))
                {
                    counter++;
                }
            }
            if (counter > 1 || counter < 1) 
                throw new InvalidOperationException();

            return item;
        }

        public T SingleOrDefault(T item)
        {
            int counter = 0;

            for (int i = 0; i < _count; i++)
            {
                if (_collection[_index].Equals(item))
                {
                    counter++;
                }
            }
            if (counter > 1 || counter < 1) 
                return default;

            return item;
        }



        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
