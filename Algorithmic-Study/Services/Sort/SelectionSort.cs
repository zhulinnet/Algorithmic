using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Sort
{
    public class SelectionSort<T> where T : IComparable
    {
        public T[] Data { get; set; }
        public SelectionSort(T[] data)
        {
            Data = data;
        }
        public T[] Sort()
        {
            for (int i = 0; i < Data.Length; i++)
            {
                var currentData = Data[i];
                var min = Data[i];
                var minIndex = i;
                for (int j = i; j < Data.Length; j++)
                {
                    if (min.CompareTo(Data[j]) > 0)
                    {
                        min = Data[j]; 
                        minIndex = j;
                    }
                }
                Data[i] = min;
                Data[minIndex] = currentData;
            }
            return Data;
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
