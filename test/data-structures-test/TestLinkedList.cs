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
            ll.Add("one");
            ll.Add("two");
            ll.Add("three");
            ll.Add("four");
            ll.Add("five");
        }

        [Fact]
        public void LinkedListCountIsCorrectAfterAdding()
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.Add("one");
            ll.Add("two");
            ll.Add("three");
            ll.Add("four");
            ll.Add("five");

            Assert.Equal(5, ll.Count);
        }

        [Fact]
        public void LinkedListCountIsCorrectBeforeAndAfterAddingOneItem()
        {
            LinkedList<string> ll = new LinkedList<string>();
            Assert.Equal(0, ll.Count);
            ll.Add("one");
            Assert.Equal(1, ll.Count);
        }

        [Fact]
        public void ClearLinkedListShouldWork()
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.Add("one");
            ll.Add("two");
            ll.Add("three");
            ll.Add("four");
            ll.Add("five");
            Assert.Equal(5, ll.Count);

            ll.Clear();

            Assert.Equal(0, ll.Count);
        }

        [Fact]
        public void TestContainsShouldWork()
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.Add("one");
            ll.Add("two");
            ll.Add("three");
            ll.Add("four");
            ll.Add("five");

            Assert.True(ll.Contains("one"));
            Assert.True(ll.Contains("two"));
            Assert.True(ll.Contains("three"));
            Assert.True(ll.Contains("four"));
            Assert.True(ll.Contains("five"));

            Assert.False(ll.Contains("zero"));
            Assert.False(ll.Contains("six"));
        }


    }
}