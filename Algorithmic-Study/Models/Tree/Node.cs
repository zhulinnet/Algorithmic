using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Models.Tree
{
    public class Node<T>
    {
        public T Data { get; set; }

        public Node<T> Left { get; set; } = null;
        public Node<T> Right { get; set; } = null;
        public Node()
        {
            Data = default;
            Left = null;
            Right = null;
        }
        public Node(T val)
        {
            Data = val;
            Left = null;
            Right = null;
        }
        public Node(Node<T> left, Node<T> right)
        {
            Left = left;
            Right = right;
        }
        public Node(T val, Node<T> left, Node<T> right)
        {
            Data = val;
            Left = left;
            Right = right;
        }

    }
}
