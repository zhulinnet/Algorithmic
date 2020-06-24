using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Interfaces
{
    interface IQueue<T>
    {
        public bool isEmpty { get; }
        public int length { get; }
        public T this[int index] { get; set; }
        public void clear();
        public void enter(T item);
        public T exit();
        public T getFront();
        public T getRear();
        public void display();
    }
}
