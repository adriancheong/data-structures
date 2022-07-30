using System;
using System.Collections.Generic;

namespace data_structures
{
    public class HashMap<K,V>
    {
        class Entry{
            private K key;
            private V value;
            public Entry(K key, V value)
            {
                this.key = key;
                this.value = value;
            }
            public K Key { get; set; }

            public V Value { get; set; }
        }

        Entry[] entries = new Entry[4];
        int entryCount = 0;
        public HashMap()
        {
        }

        public void put(K key, V value)
        {
            if (entryCount >= entries.Length / 2)
                resize();

            insert(key, value);
        }

        private void insert(K key, V value)
        {
            int hashCode = key.GetHashCode() & 0x7fffffff % entries.Length;
            entries[hashCode] = new Entry(key, value);
            entryCount++;
        }

        public V get(K key)
        {
            int hashCode = key.GetHashCode() & 0x7fffffff % entries.Length;
            return entries[hashCode].Value;
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
            Entry[] oldEntries = entries;
            entries = new Entry[entries.Length * 2];
            for (int i = 0; i < oldEntries.Length; i++)
            {
                if (oldEntries[i] != null)
                    insert(oldEntries[i].Key, oldEntries[i].Value);
            }
        }

        public int size()
        {
            return entries.Length;
        }
    }
}