using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algorithmStudy.Models.LinkedList
{
    public class Node<T>
    {
        //节点值
        private T _data;
        public T Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public Node<T> Next { get; set; } = null;
        public Node<T> Prev { get; set; } = null;
        public Node()
        {
            _data = default;
            Next = null;
        }
        public Node(T val)
        {
            _data = val;
        }
        public Node(Node<T> p)
        {
            Next = p;
        }
        public Node(T val, Node<T> p)
        {
            _data = val;
            Next = p;
        }

    }
}
