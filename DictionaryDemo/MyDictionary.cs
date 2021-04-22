using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    
        class MyDictionary<TKey, TValue>
        {
            TKey[] _keyArray;
            TValue[] _valueArray;
            TKey[] _tempKey;
            TValue[] _tempValue;
            public MyDictionary()
            {
                _keyArray = new TKey[0];
                _valueArray = new TValue[0];
            }
            public void Add(TKey keyItem, TValue valueItem)
            {
                _tempKey = _keyArray;
                _tempValue = _valueArray;

                _keyArray = new TKey[_keyArray.Length + 1];
                _valueArray = new TValue[_valueArray.Length + 1];
                for (int i = 0; i < _tempKey.Length; i++)
                {
                    _keyArray[i] = _tempKey[i];
                }

                for (int i = 0; i < _tempValue.Length; i++)
                {
                    _valueArray[i] = _tempValue[i];
                }

                _keyArray[_keyArray.Length - 1] = keyItem;
                _valueArray[_valueArray.Length - 1] = valueItem;
            }
            public TKey[] Key
            {
                get { return _keyArray; }
            }
            public TValue[] Value
            {
                get { return _valueArray; }
            }
            public int Count
            {
                get { return _keyArray.Length; }
            }
        }
}
