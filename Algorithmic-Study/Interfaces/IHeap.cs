using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Interfaces
{
    interface IHeap<T>
    {
        public void Push(T item);
        public T Pop();
    }
}
