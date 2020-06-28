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
        public Dictionary<T, double> Children { get; set; }
    }
    public class WeightedGraph<T> where T : IComparable
    {
        public List<WeightedGraphNode<T>> NodeList { get; set; }
        private bool IsWeightChange { get; set; } = false;
        private List<T> ShortestPath { get; set; } = new List<T>();
        private int updateNum { get; set; } = 0;
        public WeightedGraph()
        {
            this.NodeList = null;
        }
        public WeightedGraph(List<WeightedGraphNode<T>> graphList)
        {
            this.NodeList = graphList;
        }
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

        public List<T> GetShortest(T start, T end)
        {
            if (end == null)
            {
                ShortestPath.Reverse();
                return ShortestPath;
            }
            WeightedGraphNode<T> nodeEnd = NodeList.FirstOrDefault(s => s.Data.CompareTo(end) == 0);
            Dictionary<T, double> children = nodeEnd.Children;
            ShortestPath.Add(end);
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
                return GetShortest(start, minData);
            }
            ShortestPath.Reverse();
            return ShortestPath;
        }
    }
}
