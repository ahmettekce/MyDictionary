using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,TValue>
    {
        private T[] _key;
        private TValue[] _value;
        private int _count=0;

        public MyDictionary()
        {
            _key = new T[_count];
            _value = new TValue[_count];
        }
        public void Add(T anahtar, TValue deger)
        {
            _count++;

            T[] tempKey = _key;
            TValue[] tempValue = _value;

            _key = new T[_count + 1];
            _value = new TValue[_count + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                _key[i] = tempKey[i];
                _value[i] = tempValue[i];
            }

            _key[_count - 1] = anahtar;
            _value[_count - 1] = deger;
        }

        public T[] Anahtar
        {
            get { return _key; }
        }

        public TValue[] Deger
        {
            get { return _value; }
        }
        public int Count
        {
            get { return _count; }
        }
    }
}
