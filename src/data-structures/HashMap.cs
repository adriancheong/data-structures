using System;
using System.Collections.Generic;

namespace data_structures
{
    public class HashMap<K,V>
    {
        V[] entries = new V[4];
        int entryCount = 0;
        public HashMap()
        {
        }

        public void put(K key, V value)
        {
            if (entryCount >= entries.Length / 2)
                resize();
            int hashCode = key.GetHashCode() & 0x7fffffff % entries.Length;
            entries[hashCode] = value;
            entryCount++;
        }

        private void resize()
        {
            V[] newEntries = new V[entries.Length * 2];
            Array.Copy(entries, newEntries, entries.Length);
            entries = newEntries;
        }

        public V get(K key)
        {
            int hashCode = key.GetHashCode() & 0x7fffffff % entries.Length;
            return entries[hashCode];
        }

        public int size()
        {
            return entries.Length;
        }
    }
}