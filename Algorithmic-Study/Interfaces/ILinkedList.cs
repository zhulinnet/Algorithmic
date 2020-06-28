using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Interfaces
{
    interface ILinkedList<T>
    {
        public bool isEmpty { get; }
        public int length { get; }
        public T this[int index] { get; }
        public void clear();
        public T get(int index);
        public void insert(int index, T item);
        public void append(T item);
        public void prepend(T item);
        public void remove(int index);
        public int indexOf(T item);
    }
}
