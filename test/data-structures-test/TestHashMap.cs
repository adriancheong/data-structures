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
    }
}
