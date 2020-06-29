using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Sort
{
    public class MergeSort<T> where T : IComparable
    {
        public T[] Data { get; set; }
        private T[] SortData { get; set; }
        public MergeSort(T[] data)
        {
            Data = data;
            SortData = data;
        }

        public T[] Sort()
        {
            Sort(0, Data.Length - 1);
            return Data;
        }
        private T[] Sort(int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;
                Sort(start, middle);
                Sort(middle + 1, end);
                Merge(start, end, middle);
            }
            return Data;
        }
        private void Merge(int start, int end, int middle)
        {
            //初始化左数组
            int leftLengh = middle - start + 1;
            T[] left = new T[leftLengh];
            for (int i = 0; i < leftLengh; i++)
            {
                left[i] = Data[start + i];
            }
            //初始化右数组
            int rightLength = end - middle;
            T[] right = new T[rightLength];
            for (int j = 0; j < rightLength; j++)
            {
                right[j] = Data[middle + 1 + j];
            }
            int leftIndex = 0; int rightIndex = 0;
            for (int k = start; k <= end; k++)
            {
                if (left[leftIndex].CompareTo(right[rightIndex]) <= 0)
                {
                    Data[k] = left[leftIndex];
                    if (leftLengh - 1 == leftIndex)
                    {
                        int index = 1;
                        for (int r = rightIndex; r < rightLength; r++)
                        {
                            Data[k + index] = right[r];
                            index++;
                        }
                        break;
                    }
                    else
                    {
                        Data[k + 1] = right[rightIndex];
                    }
                    leftIndex++;
                }
                else
                {
                    Data[k] = right[rightIndex];
                    if (rightLength - 1 == rightIndex)
                    {
                        int index = 1;
                        for (int l = leftIndex; l < leftLengh; l++)
                        {
                            Data[k + index] = left[l];
                            index++;
                        }
                        break;
                    }
                    else
                    {
                        Data[k + 1] = left[leftIndex];
                    }
                    rightIndex++;
                }
            }
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
