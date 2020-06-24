using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Sort
{
    class InsertionSort<T> where T : IComparable
    {
        public T[] Data { get; set; }
        public InsertionSort(T[] data)
        {
            Data = data;
        }
        public T[] Sort()
        {
            for (int i = 0; i < Data.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    var firstNum = Data[i];
                    var secondNum = Data[j];
                    if (Data[i].CompareTo(Data[j]) < 0)
                    {
                        Data[i] = secondNum;
                        Data[j] = firstNum;
                    }
                }
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