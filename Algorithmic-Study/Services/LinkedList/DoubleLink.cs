/************************************************************************************
 *
 * 创建人：  linner	
 * 创建时间：2020-4-4 15:58:35
 * 描述：双向链表
 * 
 ************************************************************************************/

using algorithmStudy.Interfaces;
using algorithmStudy.Models.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LinkedList
{
    class DoubleLink<T> : ILinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public DoubleLink()
        {
            this.Head = null;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="head">头</param>
        public DoubleLink(Node<T> head)
        {
            this.Head = head;
            this.Tail = this.Head;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="head">头</param>
        /// <param name="tail">尾</param>
        public DoubleLink(Node<T> head, Node<T> tail)
        {
            this.Head = head;
            this.Head.Next = tail;
            this.Tail = tail;
            this.Tail.Prev = head;
        }
        /// <summary>
        /// 类索引器
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                return this.get(index);
            }
        }
        /// <summary>
        /// 判断是否为空
        /// </summary>
        public bool isEmpty => Head == null;
        /// <summary>
        /// 获取长度
        /// </summary>
        public int length
        {
            get
            {
                Node<T> node = Head;
                int len = 0;
                while (node != null)
                {
                    node = node.Next;
                    len++;
                }
                return len;
            }
        }
        /// <summary>
        /// 追加一个元素
        /// </summary>
        /// <param name="item"></param>
        public void append(T item)
        {
            if (item == null)
            {
                throw new Exception("item is not allowed to be empty");
            }
            if (this.isEmpty)
            {
                throw new Exception("Object reference not set to an instance of an object");
            }
            Node<T> temp = new Node<T>() { Data=item,Prev=Tail.Next};
            Tail.Next = temp;
            Tail = temp;
        }
        /// <summary>
        /// 清除
        /// </summary>
        public void clear()
        {
            Head = null;
        }
        /// <summary>
        /// 获取指定位置的元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T get(int index)
        {
            if (this.isEmpty)
            {
                return default(T);
            }
            Node<T> node = Head;
            int _index = 0;
            while (node != null)
            {
                if (_index == index)
                {
                    return node.Data;
                }
                node = node.Next;
                _index++;
            }
            return default(T);
        }
        /// <summary>
        /// 查找某个元素的索引
        /// </summary>
        /// <param name="item">元素</param>
        /// <returns></returns>
        public int indexOf(T item)
        {
            if (this.isEmpty)
            {
                return -1;
            }
            if (item == null)
            {
                return -1;
            }
            Node<T> node = Head;
            int _index = 0;
            while (node != null)
            {
                if (item.Equals(node.Data))
                {
                    return _index;
                }
                node = node.Next;
                _index++;
            }
            return -1;
        }
        /// <summary>
        /// 插入元素
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="item">元素</param>
        public void insert(int index, T item)
        {
            if (index == 0)
            {
                prepend(item);
                return;
            }
            if (index < 0 || index > this.length)
            {
                throw new Exception("Index exceeds list length");
            }
            if (item == null)
            {
                throw new Exception("item is not allowed to be empty");
            }
            if (this.isEmpty)
            {
                throw new Exception("Object reference not set to an instance of an object");
            }
            var temp = new Node<T>() { Data = item };
            Node<T> node = Head;
            int _index = 0;
            while (node != null)
            {
                if (_index == index - 1)
                {
                    var _next = node.Next;
                    node.Next = temp;
                    temp.Prev = node;
                    temp.Next = _next;
                    if (_next != null)
                    {
                        _next.Prev = temp;
                    }
                    else
                    {
                        Tail = temp;
                    }
                    return;
                }
                node = node.Next;
                _index++;
            }
        }
        /// <summary>
        /// 向头部追加元素
        /// </summary>
        /// <param name="item"></param>
        public void prepend(T item)
        {
            if (item == null)
            {
                throw new Exception("item is not allowed to be empty");
            }
            if (this.isEmpty)
            {
                throw new Exception("Object reference not set to an instance of an object");
            }
            Node<T> temp = new Node<T>() { Data = item, Next = Head };
            Head.Prev = temp;
            Head = temp;
        }
        /// <summary>
        /// 移除元素
        /// </summary>
        /// <param name="index">索引</param>
        public void remove(int index)
        {
            if (index < 0 || index > this.length - 1)
            {
                throw new Exception("Index exceeds list length");
            }
            if (this.isEmpty)
            {
                throw new Exception("Object reference not set to an instance of an object");
            }
            Node<T> node = Head;
            if (index == 0)
            {
                //移除第一个元素
                Head = node.Next;
                return;
            }
            int _index = 0;
            var _prev = new Node<T>();
            while (node != null)
            {
                if (_index == index - 1)
                {
                    _prev = node;//找到之前的下一个元素
                }
                if (_index == index && node.Next == null)
                {
                    //移除最后一个元素
                    _prev.Next = null;
                    Tail = _prev;
                    return;
                }
                else if (_index == index + 1)
                {
                    //移除中间的元素
                    _prev.Next = node;
                    node.Prev = _prev;
                    return;
                }
                node = node.Next;
                _index++;
            }
        }

        public void display()
        {
            Node<T> node = Head;
            int _index = 0;
            while (node != null)
            {
                Console.Write(node.Data + " ");
                node = node.Next;
                _index++;
            }
            Console.WriteLine();
        }
    }
}
