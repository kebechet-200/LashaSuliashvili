using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Practice_1.ExceptionClass;

namespace yieldReturn_Demo
{
    public class LinkedItem<T> : ILinkedItem<T>
    {
        public class Node<T>
        {
            // შემდეგი წვეროს მისამართი
            public Node<T> next = null;
            // მონაცემი
            public T data;
        }

        private Node<T> root = null;
        private int count = 0;

        public Node<T> Root
        {
            get
            {
                return root;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0) throw new IndexCantBeNegativeNumberException("Index must be zero or positive");
                if (index >= count) throw new InvalidArgumentException("Index is more than LinkedItem");
                return this.Skip(index).FirstOrDefault();
            }
            set
            {
                Node<T> current = new Node<T> { data = value};
                if (this.root == null)
                {
                    root = current;
                }
                else
                {
                    AddItem(current.data);
                }
            }
        }

        public bool Exists()
        {
            return root != null;
        }

        public void AddItem(T value)
        {
            Node<T> n = new Node<T> { data = value };
            if (root == null)
            {
                root = n;
            }
            else
            {
                Node<T> curr = root;
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = n;
            }
            count++;
        }

        public void RemoveItem(T data)
        {
            if (root != null && Object.Equals(root.data, data))
            {
                var node = root;
                root = node.next;
                node.next = null;
            }
            else
            {
                Node<T> curr = root;
                while (curr.next != null)
                {
                    if (Object.Equals(curr.next.data, data))
                    {
                        var node = curr.next;
                        curr.next = node.next;
                        node.next = null;
                        break;
                    }

                    curr = curr.next;
                }
            }
            count--;
        }

        public void PrintItems()
        {
            Node<T> curr = root;
            while (curr != null)
            {
                Console.WriteLine($"data : {curr.data.ToString()}");
                curr = curr.next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> curr = root;
            while (curr != null)
            {
                yield return curr.data;
                curr = curr.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
