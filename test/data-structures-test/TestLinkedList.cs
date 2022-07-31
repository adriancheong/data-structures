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

        [Fact]
        public void TestRemoveShouldWork()
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.Add("one");
            ll.Add("two");
            ll.Add("three");
            ll.Add("four");
            ll.Add("five");

            Assert.Equal(5, ll.Count);

            bool removed = ll.Remove("three");

            Assert.True(removed);
            Assert.Equal(4, ll.Count);
            Assert.True(ll.Contains("one"));
            Assert.True(ll.Contains("two"));
            Assert.False(ll.Contains("three"));
            Assert.True(ll.Contains("four"));
            Assert.True(ll.Contains("five"));
        }

        [Fact]
        public void TestRemoveShouldWorkForFirstItem()
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.Add("one");
            ll.Add("two");
            ll.Add("three");
            ll.Add("four");
            ll.Add("five");

            Assert.Equal(5, ll.Count);

            bool removed = ll.Remove("one");

            Assert.True(removed);
            Assert.Equal(4, ll.Count);
            Assert.False(ll.Contains("one"));
            Assert.True(ll.Contains("two"));
            Assert.True(ll.Contains("three"));
            Assert.True(ll.Contains("four"));
            Assert.True(ll.Contains("five"));
        }

        [Fact]
        public void TestRemoveShouldWorkForLastItem()
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.Add("one");
            ll.Add("two");
            ll.Add("three");
            ll.Add("four");
            ll.Add("five");

            Assert.Equal(5, ll.Count);

            bool removed = ll.Remove("five");

            Assert.True(removed);
            Assert.Equal(4, ll.Count);
            Assert.True(ll.Contains("one"));
            Assert.True(ll.Contains("two"));
            Assert.True(ll.Contains("three"));
            Assert.True(ll.Contains("four"));
            Assert.False(ll.Contains("five"));
        }

        [Fact]
        public void TestRemoveNonExistentItemShouldReturnFalse()
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.Add("one");
            ll.Add("two");
            ll.Add("three");
            ll.Add("four");
            ll.Add("five");

            Assert.Equal(5, ll.Count);

            bool removed = ll.Remove("six");

            Assert.False(removed);
            Assert.Equal(5, ll.Count);
            Assert.True(ll.Contains("one"));
            Assert.True(ll.Contains("three"));
            Assert.True(ll.Contains("five"));

        }
    }
}