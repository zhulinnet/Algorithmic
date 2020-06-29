using algorithmStudy.Services.Heap;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Sort
{
    public class HeapSort<T> where T:IComparable
    {
        public T[] Data { get; set; }
        public HeapSort(T[] data)
        {
            Data = data;
        }

        public T[] Sort()
        {
            MaxHeap<T> maxHeap = new MaxHeap<T>(Data.Length);
            foreach (T item in Data)
            {
                maxHeap.Push(item);
            }
            for(int i= Data.Length-1;i>=0;i--)
            {
                Data[i] = maxHeap.Pop();
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
