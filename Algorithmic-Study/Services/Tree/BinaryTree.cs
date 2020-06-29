using algorithmStudy.Interfaces;
using algorithmStudy.Models.Tree;
using System;
using System.Collections.Generic;

namespace algorithmStudy.Services.Tree
{
    public class BinaryTree<T> : ITree<T>
                       where T : IComparable
    {
        public Node<T> Head { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public BinaryTree()
        {
            this.Head = null;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="head">头</param>
        public BinaryTree(Node<T> head)
        {
            this.Head = head;
            this.Head.Right = null;
            this.Head.Left = null;
        }
        public bool isEmpty => Head == null;
        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            Node<T> node = Head;
            if (node == null)
            {
                node = new Node<T>() { Data = item };
                Head = node;
                return;
            }
            while (node != null)
            {
                //if (item.CompareTo(node.Data) == 0)
                //{
                //    //不允许插入相同节点
                //    throw new Exception("不允许插入相同节点");
                //}
                if (item.CompareTo(node.Data) > 0)
                {
                    //如果右节点不存在，则作为新结点添加到右下方
                    if (node.Right == null)
                    {
                        node.Right=new Node<T>() { Data = item };
                        return;
                    }
                    //大于它则往右移
                    node = node.Right;
                }
                else
                {
                    //如果左节点不存在，则作为新结点添加到左下方
                    if (node.Left == null)
                    {
                        node.Left = new Node<T>() { Data = item }; ;
                        return;
                    }
                    //小于它则往左移
                    node = node.Left;
                }
            }
        }
        /// <summary>
        /// 查找元素
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int indexOf(T item)
        {
            Node<T> node = Head;
            int _index = 0;
            if (node == null)
            {
                node = new Node<T>() { Data = item }; ;
            }
            while (node != null)
            {
                if (item.CompareTo(node.Data) == 0)
                {
                    return _index;
                }
                if (item.CompareTo(node.Data) > 0)
                {
                    //大于它则往右移
                    node = node.Right;
                }
                else
                {
                    //小于它则往左移
                    node = node.Left;
                }
                _index++;
            }
            return -1;
        }
        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
           Remove(item, Head);
        }
        /// <summary>
        /// 删除节点
        /// 参考 数据结构与算法图解   12.4 删除
        /// </summary>
        /// <param name="item"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        private Node<T> Remove(T item, Node<T> node)
        {
            //已到达树底
            if (node == null)
            {
                return null;
            }
            //要删除的节点是当前节点
            if (item.CompareTo(node.Data) == 0)
            {
                //当前没有左子树
                //用右子树替换当前节点
                if (node.Left == null)
                {
                    return node.Right;
                }
                //当前没有右子树
                //用左子树替换当前节点
                else if (node.Right == null)
                {
                    return node.Left;
                }
                //有两个子节点
                else
                {
                    node.Right = Left(node.Right, node);
                    return node;
                }
            }
            // 如果要删除的值小于（或大于）当前结点，
            // 则以左子树（或右子树）为参数，递归调用本方法，
            // 然后将当前结点的左链（或右链）指向返回的结点
            if (item.CompareTo(node.Data) > 0)
            {
                // 将当前结点（及其子树，如果存在的话）返回，
                // 作为其父结点的新左子结点（或新右子结点）
                node.Right = Remove(item, node.Right);
                return node;
            }
            else
            {
                node.Left = Remove(item, node.Left);
                return node;
            }
        }
        private Node<T> Left(Node<T> node, Node<T> nodeToDelete)
        {
            //有左子树
            //递归，从左子树找到后继节点
            if (node.Left != null)
            {
                node.Left = Left(node, nodeToDelete);
                return node;
            }
            //当前节点即为后继节点，将其值设置为被删除节点的新值
            else
            {
                nodeToDelete.Data = node.Data;
                return node.Right;
            }
        }
        private List<T> result { get; set; } = new List<T>();
        /// <summary>
        /// 先序遍历-递归实现   
        /// 根左右
        /// </summary>
        /// <param name="node"></param>
        public List<T> PreorderTraversal(Node<T> node)
        {
            if (node == null)
            {
                return result;
            }
            result.Add(node.Data);
            Console.WriteLine(node.Data);
            PreorderTraversal(node.Left);
            PreorderTraversal(node.Right);
            return result;
        }
        /// <summary>
        /// 中序遍历-递归实现 
        /// 左根右
        /// </summary>
        /// <param name="node"></param>
        public List<T> InorderTraversal(Node<T> node)
        {
            if (node == null)
            {
                return result;
            }

            InorderTraversal(node.Left);
            System.Console.WriteLine(node.Data);
            result.Add(node.Data);
            InorderTraversal(node.Right);
            return result;
        }
        /// <summary>
        /// 后序遍历-递归实现
        /// 左右根
        /// </summary>
        /// <param name="node"></param>
        public List<T> PostorderTraversal(Node<T> node)
        {
            if (node == null)
            {
                return result;
            }
            PostorderTraversal(node.Left);
            PostorderTraversal(node.Right);
            result.Add(node.Data);
            System.Console.WriteLine(node.Data);
            return result;
        }
    }
}
