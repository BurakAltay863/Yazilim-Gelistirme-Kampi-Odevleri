using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    class MyDictionary<T, T1>
    {
        T[] items;
        T1[] keys;

        public MyDictionary()
        {
            items = new T[0];
            keys = new T1[0];
        }

        public void Add(T item, T1 key)
        {
            T[] tempArray = items;
            T1[] tempKey = keys;

            items = new T[items.Length + 1];
            keys = new T1[keys.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                keys[i] = tempKey[i];
            }

            items[items.Length - 1] = item;
            keys[keys.Length - 1] = key;
        }
        public int Count
        {
            get { return items.Length; }

        }
        public int Count1
        {
            get { return keys.Length; }


        }






    }
}
