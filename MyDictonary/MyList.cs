using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class MyList<D>
    {
        D[] _array;
        D[] _tempArray;

        public MyList()
        {
            _array = new D[0];
        }
        public  void Add(D item)
        {
            _tempArray = _array;
            _array = new D[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }
    }
}
