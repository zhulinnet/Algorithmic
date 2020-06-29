using algorithmStudy.Interfaces;
using algorithmStudy.Models.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LinkedList
{
    public class LoopLink<T> : ILinkedList<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public LoopLink()
        {
            this.Head = null;
            this.Tail = null;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="head">头</param>
        public LoopLink(Node<T> head)
        {
            this.Head = head;
            this.Head.Next = this.Head;
            this.Tail = this.Head;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="head">头</param>
        /// <param name="tail">尾</param>
        public LoopLink(Node<T> head, Node<T> tail)
        {
            this.Head = head;
            this.Head.Next = tail;
            this.Tail = tail;
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
        /// 清除
        /// </summary>
        public void clear()
        {
            Head = null;
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
                if (isEmpty)
                {
                    return 0;
                }
                Node<T> node = Head;
                int len = 1;
                while (node.Next != Head)
                {
                    node = node.Next;
                    len++;
                }
                return len;
            }
        }
        /// <summary>
        /// 获取指定位置的元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T get(int index)
        {
            if (index < 0 || index > this.length - 1)
            {
                throw new Exception("Index exceeds list length");
            }
            if (this.isEmpty)
            {
                return default(T);
            }
            Node<T> node = Head;
            int _index = 0;
            while (node.Next != Head)
            {
                if (_index == index)
                {
                    return node.Data;
                }
                node = node.Next;
                _index++;
            }
            return node.Data;
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
            Node<T> node = Head;
            Node<T> temp = new Node<T>() { Data = item, Next = null };
            int _index = 0;
            while (node != null)
            {
                if (_index == index - 1)
                {
                    temp.Next = node.Next;
                    node.Next = temp;
                    if (temp.Next == Head)
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
        /// 在链表尾部追加元素
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
            Node<T> node = Head;
            Node<T> temp = new Node<T>() { Data = item, Next = Head };
            int _index = 0;
            while (node != null)
            {
                if (node.Next == Head)
                {
                    node.Next = temp;
                    Tail = temp;
                    return;
                }
                node = node.Next;
                _index++;
            }
        }
        /// <summary>
        /// 在链表头部追加元素
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
            Node<T> node = Head;
            Node<T> temp = new Node<T>() { Data = item, Next = Head };
            int _index = 0;
            while (node != null)
            {
                if (node.Next == Head)
                {
                    node.Next = temp;
                    Head = temp;
                    return;
                }
                node = node.Next;
                _index++;
            }
        }
        /// <summary>
        /// 移除某个索引的元素
        /// </summary>
        /// <param name="index"></param>
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
            int _index = 0;
            var temp = new Node<T>();
            if (index == 0)
            {
                //移除第一个元素
                Head = node.Next;
                Tail.Next = Head;
                return;
            }
            while (node != null)
            {

                if (_index == index - 1)
                {
                    temp = node;//之前的下一个元素
                }
                if (_index == index)
                {
                    var _next = node.Next;
                    temp.Next = _next;
                    if (temp.Next == Head)
                    {
                        Tail = temp;
                    }
                    return;
                }
                node = node.Next == Head ? null : node.Next;
                _index++;
            }
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
                node = node.Next == Head ? null : node.Next;
                _index++;
            }
            return -1;
        }

        public List<T> display()
        {
            List<T> result = new List<T>();
            Node<T> node = Head;
            int _index = 0;
            while (node != null)
            {
                Console.Write(node.Data + " ");
                result.Add(node.Data);
                node = node.Next == Head ? null : node.Next;
                _index++;
            }
            Console.WriteLine();
            Console.WriteLine("----Next----");
            node = Head;
            while (node != null)
            {
                Console.Write(node.Next.Data + " ");
                node = node.Next == Head ? null : node.Next;
                _index++;
            }
            Console.WriteLine();
            return result;
        }

    }
}
