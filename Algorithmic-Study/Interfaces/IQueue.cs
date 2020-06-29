using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Interfaces
{
    interface IQueue<T>
    {
        public bool isEmpty { get; }
        public int length { get; }
        public void clear();
        public void enter(T item);
        public T exit();
        public T getFront();
        public T getRear();
    }
}
