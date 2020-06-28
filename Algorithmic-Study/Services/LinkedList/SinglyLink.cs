using algorithmStudy.Interfaces;
using algorithmStudy.Models.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithmStudy.Services.LinkedList
{
    public class SinglyLink<T> : ILinkedList<T>
    {
        public Node<T> Head { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public SinglyLink()
        {
            this.Head = null;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="head">头</param>
        public SinglyLink(Node<T> head)
        {
            this.Head = head;
            this.Head.Next = null;
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
        /// 插入元素
        /// </summary>
        /// <param name="index">索引</param>
        /// <param name="item">元素</param>
        public void insert(int index, T item)
        {
            if (index < 0||index>this.length)
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
            int _index = 0;
            while (node != null)
            {
                if (index == 0)
                {
                    //在头部插入元素
                    node = new Node<T>() { Data = item, Next = Head };
                    Head = node;
                    return;
                }
                if (_index == index - 1)
                {
                    var _next = node.Next;//之前的下一个元素
                    node.Next = new Node<T>() { Data = item, Next = _next };
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
            int _index = 0;
            while (node != null)
            {
                if (node.Next==null)
                {
                    node.Next = new Node<T>() { Data = item, Next = null };
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
            Node<T> node = new Node<T>() { Data = item, Next = Head };
            Head = node;
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
                    return;
                }
                else if (_index == index + 1)
                {
                    //移除中间的元素
                    _prev.Next = node;
                    return;
                }
                node = node.Next;
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
                node = node.Next;
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
                node = node.Next;
                _index++;
            }
            Console.WriteLine();
            return result;
        }
    }
}
