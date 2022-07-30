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
    }
}
