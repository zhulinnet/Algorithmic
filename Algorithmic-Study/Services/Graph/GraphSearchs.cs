using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithmStudy.Services.Graph
{
    public class GraphNode<T>
    {
        public T Data { get; set; }
        public bool Visited { get; set; } = false;
        public T[] Children { get; set; }
    }
    public class GraphSearchs<T> where T : IComparable
    {
        public List<GraphNode<T>> NodeList { get; set; }
        private Queue<T> BackupQueue { get; set; }
        private Stack<T> BackupStack { get; set; }
        private List<T> Path { get; set; } = new List<T>();
        public GraphSearchs()
        {
            this.BackupQueue = new Queue<T>();
            this.BackupStack = new Stack<T>();
            this.NodeList = null;
        }
        public GraphSearchs(List<GraphNode<T>> graphList)
        {
            this.BackupQueue = new Queue<T>();
            this.BackupStack = new Stack<T>();
            this.NodeList = graphList;
        }
        public List<GraphNode<string>> InitSeed()
        {
            List<GraphNode<string>> seed = new List<GraphNode<string>>();
            seed.Add(new GraphNode<string>() { Data = "Alice",Children= new[] { "Bob", "Diana", "Fred" } } );
            seed.Add(new GraphNode<string>() { Data = "Bob", Children = new[] { "Alice", "Cynthia", "Diana" } });
            seed.Add(new GraphNode<string>() { Data = "Cynthia", Children = new[] { "Bob" } });
            seed.Add(new GraphNode<string>() { Data = "Diana", Children = new[] { "Alice", "Bob", "Fred" } });
            seed.Add(new GraphNode<string>() { Data = "Elise", Children = new[] { "Fred" } });
            seed.Add(new GraphNode<string>() { Data = "Fred", Children = new[] { "Alice", "Diana", "Elise" } });
            return seed;
        }
        /// <summary>
        /// 广度优先算法
        /// </summary>
        /// <param name="start">开始的节点</param>
        /// <param name="end">结束的节点</param>
        /// <returns>路径</returns>
        public List<T> BFS(T start, T end = default(T))
        {
            if (NodeList == null)
            {
                //图为空
                return Path;
            }
            if (start.CompareTo(end) == 0)
            {
                //已查询到目标节点
                return Path;
            }
            GraphNode<T> node = NodeList.FirstOrDefault(s => s.Data.CompareTo(start) == 0);
            if (node != null&&!node.Visited)
            {
                T[] children  = node.Children;
                if (children != null)
                {
                    //将候补节点加入队列
                    foreach (T item in children)
                    {
                        BackupQueue.Enqueue(item);
                    }
                }
                Path.Add(start);
                Console.WriteLine(start);
                node.Visited = true;
            }
            if (BackupQueue.Count == 0)
            {
                return Path;
            }
          
            return BFS(BackupQueue.Dequeue(), end);
        }
        /// <summary>
        /// 深度优先算法
        /// </summary>
        /// <param name="start">开始的节点</param>
        /// <param name="end">结束的节点</param>
        /// <returns>路径</returns>
        public List<T> DFS(T start, T end = default(T))
        {
            if (NodeList == null)
            {
                //图为空
                return Path;
            }
            if (start.CompareTo(end) == 0)
            {
                //已查询到目标节点
                return Path;
            }
            GraphNode<T> node = NodeList.FirstOrDefault(s => s.Data.CompareTo(start) == 0);
            if (node != null && !node.Visited)
            {
                T[] children = node.Children;
                if (children != null)
                {
                    //将候补节点入栈
                    foreach (T item in children)
                    {
                        BackupStack.Push(item);
                    }
                }
                Path.Add(start);
                Console.WriteLine(start);
                node.Visited = true;
            }
            if (BackupStack.Count == 0)
            {
                return Path;
            }
            return DFS(BackupStack.Pop(), end);
        }

    }
}
