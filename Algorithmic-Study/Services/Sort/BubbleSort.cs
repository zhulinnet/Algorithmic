using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace algorithmStudy.Services.Sort
{
    public class BubbleSort<T> where T:IComparable
    {
        public T[] Data { get; set; }
        public BubbleSort(T[] data)
        {
            Data = data;
        }

        public T[] Sort()
        {
            //从大到小
            //for (int i = Data.Length - 1; i >= 0; i--)
            //{
            //    for (int j = i - 1; j >= 0; j--)
            //    {
            //        var firstNum = Data[i];
            //        var secondNum = Data[j];
            //        if (secondNum.CompareTo(firstNum) < 0)
            //        {
            //            Data[i] = secondNum;
            //            Data[j] = firstNum;
            //        }
            //    }
            //}
            //从小到大
            for (int i = 0; i < Data.Length - 1; i++)
            {
                for (int j = i + 1; j < Data.Length; j++)
                {
                    var firstNum = Data[i];
                    var secondNum = Data[j];
                    if (secondNum.CompareTo(firstNum) < 0)
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
                Console.Write(item+" ");
            }                
            Console.WriteLine();
        }
    }
}
