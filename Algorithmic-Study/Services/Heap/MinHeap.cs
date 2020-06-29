using algorithmStudy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Heap
{
    /// <summary>
    /// 参考https://blog.csdn.net/w199753/article/details/104733815
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MinHeap<T> : IHeap<T>
                            where T : IComparable
    {
        /// <summary>
        /// 容量
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        private T[] Data { get; set; }
        /// <summary>
        /// 当前长度
        /// </summary>
        private int Size { get; set; } = 0;
        public MinHeap(int capacity=100)
        {
            Capacity = capacity;
            Data = new T[Capacity+1];
        }
        public void Push(T item)
        {
            if (Capacity <= Size)
            {
                return;
            }
            Data[++Size] = item;
            int childIdx = Size;
            while (childIdx > 1)
            {
                int parentIdx = childIdx / 2;
                if (Data[parentIdx].CompareTo(Data[childIdx]) <= 0)
                {
                    break;
                }
                T currentC = Data[childIdx];
                T currentP = Data[parentIdx];
                Data[childIdx] = currentP;
                Data[parentIdx] = currentC;
                childIdx = parentIdx;
            }
        }
        public T Pop()
        {
            T min = Data[1];
            int parentIdx = 1;
            int lastIndex = Size--;
            Data[1] = Data[lastIndex];
            Data[lastIndex] = default(T);
            while (parentIdx * 2 <= Size)
            {
                int leftchildIdx = parentIdx * 2;
                if (Data[leftchildIdx + 1].CompareTo(Data[leftchildIdx]) < 0 && leftchildIdx + 1 <= Size)
                {
                    leftchildIdx++;
                }
                if (Data[parentIdx].CompareTo(Data[leftchildIdx])<=0)
                {
                    return min;
                }
                T currentC = Data[leftchildIdx];
                T currentP = Data[parentIdx];
                Data[leftchildIdx] = currentP;
                Data[parentIdx] = currentC;
                parentIdx = leftchildIdx;
            }
            return min;
        }

        public List<T> display()
        {
            List<T> result = new List<T>();
            for (int i = 1; i <= Size; i++)
            {
                Console.Write(Data[i] + " ");
                result.Add(Data[i]);
            }
            Console.WriteLine();
            return result;
        }
    }
}
