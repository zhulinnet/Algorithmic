using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.ArraySearch
{
    class LinearSearch<T> where T : IComparable
    {
        public T[] Data { get; set; }
        public LinearSearch(T[] data)
        {
            Data = data;
        }

        public int Search(T item)
        {
            for (int i = 0; i < Data.Length; i++)
            {
                if (Data[i].CompareTo(item) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
