using algorithmStudy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Queue
{
    public class SeqQueue<T> : IQueue<T>
    {
        public int MaxLength { get; set; }
        public T[] Data { get; set; }
        public int Front { get; set; }
        public int Rear { get; set; }
        /// <summary>
        ///  构造函数
        /// </summary>
        /// <param name="length">栈容量</param>
        public SeqQueue(int length)
        {
            Data = new T[length];
            Front = Rear = -1;
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

        public bool isEmpty => Front == Rear;

        public int length => Rear + 1;
        public bool isFull => Rear + 1 == MaxLength;

        public void clear()
        {
            Front = Rear = -1;
        }

        public void display()
        {
            if (!isEmpty)
            {
                for (int i = Front; i <= Rear; i++)
                {
                    Console.Write(Data[i] + " ");
                }
                Console.WriteLine();
            }
        }

        public void enter(T item)
        {
            if (isFull)
            {
                throw new Exception("queue is full");
            }
            Data[Rear + 1] = item;
            if (Front == -1)
            {
                Front = 0;
            }
            Rear++;
        }

        public T exit()
        {
            if (isEmpty)
            {
                throw new Exception("queue is empty");
            }
            T temp = Data[Front];
            Front++;
            return temp;
        }

        public T getFront()
        {
            if (isEmpty)
            {
                throw new Exception("queue is empty");
            }
            return Data[Front];
        }

        public T getRear()
        {
            if (isEmpty)
            {
                throw new Exception("queue is empty");
            }
            return Data[Rear];
        }
    }
}
