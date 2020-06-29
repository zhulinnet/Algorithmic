using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Interfaces
{
    interface IStack<T>
    {
        public bool isEmpty { get; }
        public int length { get; }
        public void clear();
        public void push(T item);
        public T pop();
        public T getTop();
    }
}
