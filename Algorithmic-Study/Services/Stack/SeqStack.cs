using algorithmStudy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Stack
{
    public class SeqStack<T> : IStack<T>
    {
        public int MaxLength { get; set; }

        public T[] Data { get; set; }
        public int Top { get; set; }
        /// <summary>
        ///  构造函数
        /// </summary>
        /// <param name="length">栈容量</param>
        public SeqStack(int length)
        {
            Data = new T[length];
            Top = -1;
            MaxLength = length;
        }
        public T this[int index]
        {
            get
            {
                return Data[index];
            }
            set
            {
                Data[index] = value;
            }
        }

        public bool isEmpty => Top==-1;
        public bool isFull => Top + 1 == MaxLength;

        public int length => Top+1;

        public void clear()
        {
            Top = -1;
        }

        public void display()
        {
            if (!isEmpty)
            {
                for (int i = Top; i > -1; i--)
                {
                    Console.Write(Data[i]+" ");
                }
                Console.WriteLine();
            }
        }

        public T pop()
        {
            if (isEmpty)
            {
                throw new Exception("stack is empty");
            }
            T temp = Data[Top];
            Top--;
            return temp;
        }


        public void push(T item)
        {
            if (isFull)
            {
                throw new Exception("stack is full");
            }
            Data[Top+1] = item;
            Top++;
        }

        public T getTop()
        {
            if (isEmpty)
            {
                throw new Exception("stack is empty");
            }
            return Data[Top];
        }
    }
}
