using System;
using System.Collections;
using System.Collections.Generic;

namespace data_structures
{
    public class LinkedList<T> : ICollection<T>
    {
        Node<T> firstItem;

        public int Count
        {
            get
            {
                return count();
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        class Node<T>
        {
            public Node(T item)
            {
                this.Item = item;
            }
            public T Item { get; set; }
            public Node<T> Next { get; set; }
        }

        public void Add(T item)
        {
            if (firstItem == null)
                firstItem = new Node<T>(item);
            else
            {
                var newNode = new Node<T>(item);
                newNode.Next = firstItem;
                firstItem = newNode;
            }
        }

        private int count()
        {
            int count = 0;
            var iter = firstItem;
            
            for (Node<T> i = firstItem; i != null; i = i.Next)
                count++;

            //Another way to achieve the same count as the above for educational purposes.    
            // while (iter != null)
            // {
            //     count++;
            //     iter = iter.Next;
            // }
            
            return count;
        }

        public void Clear()
        {
            firstItem = null;
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}