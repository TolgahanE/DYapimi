using System;
using System.Collections.Generic;

namespace DYapimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(1, "Tolgahan");
            ogrenci.Add(2, "Halim");
            Console.WriteLine(ogrenci.Count);


            MyDictionary<string, int> ogrenci1 = new MyDictionary<string, int>();
            ogrenci1.Add("Veli", 1);
            ogrenci1.Add("Ali", 2);
            Console.WriteLine(ogrenci1.Count);


        }
    }

    class MyDictionary<A, B>
    {
        A[] _array1;
        B[] _array2;

        A[] _tempArray1;
        B[] _tempArray2;

        public MyDictionary()
        {
            _array1 = new A[0];
            _array2 = new B[0];
        }


        public void Add(A tutucu, B verici)
        {

            _tempArray1 = _array1;
            _tempArray2 = _array2;

            _array1 = new A[_array1.Length + 1];
            _array2 = new B[_array2.Length + 1];

            for (int i = 0; i < _tempArray1.Length; i++)
            {
                _array1[i] = _tempArray1[i];
            }
            _array1[_array1.Length - 1] = tutucu;

            for (int i = 0; i < _tempArray2.Length; i++)
            {
                _array2[i] = _tempArray2[i];
            }

            _array2[_array2.Length - 1] = verici;

        }

        public int Count
        {
            get { return _array1.Length; }
        }


    }
}