using System;
using System.Collections;
using System.Collections.Generic;

namespace data_structures
{
    public class LinkedList<T> : ICollection<T>
    {
        Node firstItem;
        MyEnumerator enumerator;

        public LinkedList()
        {
            enumerator = new MyEnumerator();            
        }
        public int Count
        {
            get
            {
                return count();
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        class Node
        {
            public Node()
            {
                
            }
            public Node(T item)
            {
                this.Item = item;
            }
            public T Item { get; set; }
            public Node Next { get; set; }
        }

        class MyEnumerator : IEnumerator<T>
        {
            public MyEnumerator()
            {
                CurrentNode = new Node();
            }
            public T Current {
                get { return CurrentNode.Item; } 
            }
            public Node CurrentNode { get; set; }

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                if (CurrentNode.Next != null)
                {
                    CurrentNode = CurrentNode.Next;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            if (firstItem == null)
            {
                firstItem = new Node(item);
            }
            else
            {
                var newNode = new Node(item);
                newNode.Next = firstItem;
                firstItem = newNode;
            }
            enumerator.CurrentNode.Next = firstItem;
        }

        private int count()
        {
            int count = 0;
            var iter = firstItem;
            
            for (Node i = firstItem; i != null; i = i.Next)
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
            for (Node i = firstItem; i != null; i = i.Next)
            {
                if (item.Equals(i.Item))
                    return true;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            Node prev = null;

            for (Node i = firstItem; i != null; i = i.Next)
            {
                if (item.Equals(i.Item))
                {
                    if (i == firstItem)
                    {
                        firstItem = i.Next;
                        return true;
                    }
                    else
                    {
                        prev.Next = i.Next;
                        return true;
                    }
                }
                prev = i;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}