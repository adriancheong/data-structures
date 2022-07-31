using System;

namespace data_structures
{
    public class LinkedList<T>
    {
        Node<T> firstItem;
        class Node<T>
        {
            public Node(T item)
            {
                this.Item = item;
            }
            public T Item { get; set; }
            public Node<T> Next { get; set; }
        }

        public void AddFirst(T item)
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

        public int count()
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
    }
}