using System;
using Xunit;

namespace data_structures
{
    public class TestHashMap
    {
        [Fact]
        public void TestHashMapCanAddThings()
        {
            HashMap<string, int> hm = new HashMap<string, int>();
            hm.put("one", 1);
        }

        [Fact]
        public void HashMapCanGetAfterPutting()
        {
            int expected = 1;
            HashMap<string, int> hm = new HashMap<string, int>();
            hm.put("one", expected);

            int actual = hm.get("one");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HashMapCanGrowAutomatically()
        {
            // Given
            HashMap<string, int> hm = new HashMap<string, int>();
            hm.put("one", 1);
            hm.put("two", 2);
            Assert.Equal(4, hm.size());
            hm.put("three", 3);
            Assert.Equal(8, hm.size());
            hm.put("four", 4);
            Assert.Equal(8, hm.size());
            hm.put("five", 5);
            Assert.Equal(16, hm.size());

        }

        [Fact]
        public void PutFourItemsAndGetThemAll()
        {
            // Given
            HashMap<string, int> hm = new HashMap<string, int>();
            hm.put("one", 1);
            hm.put("two", 2);
            hm.put("three", 3);
            hm.put("four", 4);

            Assert.Equal(1, hm.get("one"));
            Assert.Equal(2, hm.get("two"));
            Assert.Equal(3, hm.get("three"));
            Assert.Equal(4, hm.get("four"));
        }

        [Fact]
        public void PutThreeItemsAndGetThemAll()
        {
            // Given
            HashMap<string, int> hm = new HashMap<string, int>();
            hm.put("one", 1);
            hm.put("two", 2);
            hm.put("three", 3);
 
            Assert.Equal(1, hm.get("one"));
            Assert.Equal(2, hm.get("two"));
            Assert.Equal(3, hm.get("three"));
        }


        [Fact]
        public void PutFiveItemsAndGetThemAll()
        {
            // Given
            HashMap<string, int> hm = new HashMap<string, int>();
            hm.put("one", 1);
            hm.put("two", 2);
            hm.put("three", 3);
            hm.put("four", 4);
            hm.put("five", 5);

            Assert.Equal(1, hm.get("one"));
            Assert.Equal(2, hm.get("two"));
            Assert.Equal(3, hm.get("three"));
            Assert.Equal(4, hm.get("four"));
            Assert.Equal(5, hm.get("five"));
        }

        [Fact]
        public void PutFiveItemsAndGetThemAllIntegerKeyAndStringValue()
        {
            // Given
            HashMap<int, string> hm = new HashMap<int, string>();
            hm.put(1, "one");
            hm.put(2, "two");
            hm.put(3, "three");
            hm.put(4, "four");
            hm.put(5, "five");

            Assert.Equal("one", hm.get(1));
            Assert.Equal("two", hm.get(2));
            Assert.Equal("three", hm.get(3));
            Assert.Equal("four", hm.get(4));
            Assert.Equal("five", hm.get(5));
        }


        [Fact]
        public void EntryCountShouldBeFiveAfterAddingFiveItems()
        {
            // Given
            HashMap<string, int> hm = new HashMap<string, int>();
            hm.put("one", 1);
            hm.put("two", 2);
            hm.put("three", 3);
            hm.put("four", 4);
            hm.put("five", 5);

            Assert.Equal(5, hm.length());
        }

        [Fact]
        public void UpdateHashMapWithSameKeyShouldWork()
        {
            // Given
            HashMap<string, int> hm = new HashMap<string, int>();
            hm.put("one", 1);
            hm.put("one", 2);

            Assert.Equal(2, hm.get("one"));
        }

        [Fact]
        public void UpdateHashMapWithSameKeyFiveTimesShouldWork()
        {
            // Given
            HashMap<string, int> hm = new HashMap<string, int>();
            hm.put("one", 1);
            hm.put("one", 2);
            hm.put("one", 3);
            hm.put("one", 4);
            hm.put("one", 5);

            Assert.Equal(5, hm.get("one"));
        }

        [Fact]
        public void UpdateHashMapWithSameKeyCountShouldRemainSame()
        {
            // Given
            HashMap<string, int> hm = new HashMap<string, int>();
            hm.put("one", 1);
            hm.put("one", 2);

            Assert.Equal(1, hm.length());
        }
    }
}
