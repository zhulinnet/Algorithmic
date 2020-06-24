using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithmStudy.Services.ArraySearch
{
    class BinarySearch<T> where T : IComparable
    {
        //必须为顺序列表，从小到大
        public T[] Data { get; set; }
        public BinarySearch(T[] data)
        {
            Data = data;
        }
        public int Search(T item)
        {
            return Search(item, 0, Data.Length - 1);
        }
        private int Search( T item,int start,int end)
        {
            int middle= (start + end) / 2;
            if (end == -1||start>end)
            {
                return -1;
            }
            if (Data[middle].CompareTo(item) == 0)
            {
                return middle;
            }
            if (Data[middle].CompareTo(item) > 0)
            {
                return Search(item, start, middle - 1);
            }
            return Search( item, middle + 1, end);
        }
    }
}
