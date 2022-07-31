using System;
using Xunit;

namespace data_structures
{
    public class TestLinkedList
    {
        [Fact]
        public void LinkedListCanAddItems()
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.AddFirst("one");
            ll.AddFirst("two");
            ll.AddFirst("three");
            ll.AddFirst("four");
            ll.AddFirst("five");
        }

        [Fact]
        public void LinkedListCountIsCorrectAfterAdding()
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.AddFirst("one");
            ll.AddFirst("two");
            ll.AddFirst("three");
            ll.AddFirst("four");
            ll.AddFirst("five");

            Assert.Equal(5, ll.count());
        }

                [Fact]
        public void LinkedListCountIsCorrectBeforeAndAfterAddingOneItem()
        {
            LinkedList<string> ll = new LinkedList<string>();
            Assert.Equal(0, ll.count());
            ll.AddFirst("one");
            Assert.Equal(1, ll.count());
        }


    }
}