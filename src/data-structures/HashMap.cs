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

        public V get(K key)
        {
            int hashCode = key.GetHashCode() & 0x7fffffff % entries.Length;
            return entries[hashCode];
        }

        private int getStringHash(string s)
        {
            int hash = 7;
            for (int i = 0; i < s.Length; i++) {
                hash = hash*31 + s[i];
            }
            return hash;
        }

        private void resize()
        {
            V[] newEntries = new V[entries.Length * 2];
            Array.Copy(entries, newEntries, entries.Length);
            entries = newEntries;
            //bug is prob here? When copy, need to rehash all the items?
        }

        public int size()
        {
            return entries.Length;
        }
    }
}