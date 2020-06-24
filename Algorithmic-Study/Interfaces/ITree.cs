using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Interfaces
{
    interface ITree<T>
    {
        public bool isEmpty { get; }
        public int indexOf(T item);
        public void Add(T item);
        public void Remove(T item);
    }
}
