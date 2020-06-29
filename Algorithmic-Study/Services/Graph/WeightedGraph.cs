using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace algorithmStudy.Services.Graph
{
    public class WeightedGraphNode<T>
    {
        public T Data { get; set; }
        //初始权重：起点为0，其他顶点为无穷大（∞）
        public double Weight { get; set; } = double.MaxValue;
        public bool Visited { get; set; } = false;
        public Dictionary<T, double> Children { get; set; }
    }
    public class WeightedGraph<T> where T : IComparable
    {
        public List<WeightedGraphNode<T>> NodeList { get; set; }
        private bool IsWeightChange { get; set; } = true;
        private List<WeightedGraphNode<T>> BackupList { get; set; } 
        private int updateNum { get; set; } = 0;
        public WeightedGraph()
        {
            this.NodeList = null;
            this.BackupList = new List<WeightedGraphNode<T>>();
        }
        public WeightedGraph(List<WeightedGraphNode<T>> graphList)
        {
            this.NodeList = graphList;
            this.BackupList = new List<WeightedGraphNode<T>>();
        }
        /// <summary>
        /// 贝尔曼-福特算法
        /// </summary>
        public void BellmanFord()
        {
            if (NodeList == null)
            {
                //图为空
                return;
            }
            updateNum++;
            if (updateNum >= NodeList.Count)
            {
                //该图有负权回路
                return;
            }
            foreach (var node in NodeList)
            {
                if (!IsWeightChange)
                {
                    return;
                }
                Dictionary<T, double> children = node.Children;
                if (children != null)
                {
                    foreach (var itemC in children)
                    {
                        WeightedGraphNode<T> nodeChildren = NodeList.FirstOrDefault(s => s.Data.CompareTo(itemC.Key) == 0);
                        var currentWeight = node.Weight + itemC.Value;
                        if (currentWeight.CompareTo(nodeChildren.Weight) < 0)
                        {
                            nodeChildren.Weight = currentWeight;
                            IsWeightChange = true;
                        }
                        else
                        {
                            IsWeightChange = false;
                        }
                    }
                }
            }
            BellmanFord();
        }
        /// <summary>
        /// 狄克斯特拉算法
        /// 如果图中含有负数权重，狄克斯特拉算法可能会无法得出正确答案
        /// </summary>
        public void Dijkstra(T current,T end)
        {
            if (NodeList == null)
            {
                //图为空
                return;
            }
            if (current.CompareTo(end)==0)
            {
                return;
            }
            WeightedGraphNode<T> nodeCurrent = NodeList.FirstOrDefault(s => s.Data.CompareTo(current) == 0);
            if (nodeCurrent == null)
            {
                return;
            }
            nodeCurrent.Visited = true;
            Dictionary<T, double> children = nodeCurrent.Children;
            if (children != null)
            {
                foreach (var itemC in children)
                {
                    WeightedGraphNode<T> nodeChildren = NodeList.FirstOrDefault(s => s.Data.CompareTo(itemC.Key) == 0);
                    if (nodeChildren.Visited)
                    {
                        continue;
                    }
                    var currentWeight = nodeCurrent.Weight + itemC.Value;
                    if (currentWeight.CompareTo(nodeChildren.Weight) < 0)
                    {
                        nodeChildren.Weight = currentWeight;
                    }
                    BackupList.Add(nodeChildren);
                }
            }
            var minData = default(T);
            if (BackupList.Count > 0)
            {
                double weight = double.MaxValue;
                foreach (var backup in BackupList)
                {
                    if (backup.Weight < weight)
                    {
                        weight = backup.Weight;
                        minData = backup.Data;
                    }
                }
            }
            WeightedGraphNode<T> nodeMin = NodeList.FirstOrDefault(s => s.Data.CompareTo(minData) == 0);
            BackupList.Remove(nodeMin);
            Dijkstra(minData,end);
        }
        public void GetShortest(ref List<T> path,T start, T end)
        {
            if (end == null)
            {
                return;
            }
            WeightedGraphNode<T> nodeEnd = NodeList.FirstOrDefault(s => s.Data.CompareTo(end) == 0);
            Dictionary<T, double> children = nodeEnd.Children;
            path.Add(end);
            if (children != null)
            {
                var minData = default(T);
                foreach (var itemC in children)
                {
                    WeightedGraphNode<T> nodeC = NodeList.FirstOrDefault(s => s.Data.CompareTo(itemC.Key) == 0);

                    if ((nodeEnd.Weight - itemC.Value).CompareTo(nodeC.Weight) == 0)
                    {
                        minData = nodeC.Data;
                        break;
                    }
                }
                GetShortest(ref path,start, minData);
            }
        }
    }
}
