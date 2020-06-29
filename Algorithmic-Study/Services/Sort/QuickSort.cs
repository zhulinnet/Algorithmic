using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithmStudy.Services.Sort
{
    public class QuickSort<T> where T : IComparable
    {
        public T[] Data { get; set; }
        public QuickSort(T[] data)
        {
            Data = data;
        }

        public T[] Sort()
        {
            Sort(0, Data.Length - 1);
            return Data;
        }
        private void Sort(int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int baseIndex = QSort(start, end);
            Sort(start, baseIndex);
            Sort(baseIndex + 1, end);
        }
        private int QSort(int start, int end)
        {
            //基准值
            int baseIndex = start;
            T baseData = Data[start];
            for (int i = start; i <= end; i++)
            {
                if (baseIndex != i)
                {
                    if (Data[i].CompareTo(baseData) < 0)
                    {
                        for (int j = baseIndex; j <= i; j++)
                        {
                            var temp = Data[i];
                            Data[i] = Data[j];
                            Data[j] = temp;
                        }
                        baseIndex = baseIndex++;
                    }
                }
            }
            return baseIndex;
        }
        public void display()
        {
            Data = Sort();
            foreach (T item in Data)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
