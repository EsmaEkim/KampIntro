using System;

namespace MyDictionaryIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Esma");
            myDictionary.Add(2, "Eylül");
            myDictionary.Add(3, "Ekim");
            myDictionary.Add(4, "Kasım");

            Console.WriteLine("kayıt sayısı: " + myDictionary.Count);
        }
        class MyDictionary<TKey, TValue>
        {
            TKey[] _key;
            TValue[] _value;
            TKey[] _tempkey;
            TValue[] _tempvalue;
            public MyDictionary()
            {
                _key = new TKey[0];
                _value = new TValue[0];
                _tempkey = new TKey[0];
                _tempvalue = new TValue[0];
            }
            public void Add(TKey item, TValue item2)
            {

                _key = new TKey[_tempkey.Length + 1];
                _tempkey = _key;
                _value = new TValue[_tempvalue.Length + 1];
                _tempvalue = _value;

                for (int i = 0; i < _tempkey.Length; i++)
                {
                    _key[i] = _tempkey[i];
                }
                _key[_key.Length - 1] = item;

                for (int i = 0; i < _tempvalue.Length; i++)
                {
                    _value[i] = _tempvalue[i];
                }
                _value[_value.Length - 1] = item2;
            }
            public int Count
            {
                get { return _key.Length; }


            }
        }
    }
}
