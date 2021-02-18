using System;
using System.Collections.Generic;
using System.Text;

namespace DictonaryIntro
{
    class MyDictonary<T,T1>
    {
        T[] _array;
        T1[] _array1;
        T[] tempArray;
        T1[] tempArray1; 
        public MyDictonary()
        {
            _array = new T[0]; 
            _array1 = new T1[0];

        }
        public void Add(T item_T,T1 item_T1)
        {
            tempArray = _array;
            tempArray1 = _array1;

            _array = new T[_array.Length + 1];
            _array1 = new T1[_array1.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                _array[i] = tempArray[i];
                _array1[i] = tempArray1[i];

            }

            _array[_array.Length - 1] = item_T;
            _array1[_array1.Length - 1] = item_T1;

        }

        public int Count
        {
            get { return _array.Length; }
        }
    }
}
