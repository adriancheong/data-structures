using System;
using System.Collections.Generic;

namespace data_structures
{
    public class HashMap<K,V>
    {
        class Entry{
            public Entry(K key, V value)
            {
                this.Key = key;
                this.Value = value;
            }
            public K Key { get; set; }
            public V Value { get; set; }
            public Entry Next { get; set; }
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
            int hashCode = getStringHash(key.ToString()) & 0x7fffffff % entries.Length;
            if (entries[hashCode] == null)
                entries[hashCode] = new Entry(key, value);
            else
            {
                //Check for PUT update
                // for (Entry e = entries[hashCode]; e != null; e = e.Next)
                // {
                //     if (key.Equals(e.Value))
                //     {
                //         entries[hashCode].Value = value;
                //         return;
                //     }
                // }

                //If no update means no match in object, add it as new item in bucket hash collision
                var next = entries[hashCode];
                entries[hashCode] = new Entry(key, value);
                entries[hashCode].Next = next;
            }

            entryCount++;
        }

        public V get(K key)
        {
            int hashCode = getStringHash(key.ToString()) & 0x7fffffff % entries.Length;
            for (Entry e = entries[hashCode]; e != null; e = e.Next)
            {
                if (key.Equals(e.Key))
                    return e.Value;
            }
            throw new NotImplementedException();
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
            entryCount = 0;
            for (int i = 0; i < oldEntries.Length; i++)
            {
                for (Entry e = oldEntries[i]; e != null; e = e.Next)
                {
                    insert(e.Key, e.Value);
                }
            }
        }

        public int length()
        {
            return entryCount;
        }

        public int size()
        {
            return entries.Length;
        }
    }
}