using algorithmStudy.Models.Clustering;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.Clustering
{
    public class Hierarchical
    {
        public class Cluster
        {
            public List<Pointer> Pointers { get; set; }
        }
        public List<Pointer> Pointers { get; set; }
        public Hierarchical(List<Pointer> pointers)
        {
            this.Pointers = pointers;
        }
        /// <summary>
        /// Hierarchical算法
        /// </summary>
        /// <param name="centerCount">簇个数</param>
        /// <returns></returns>
        public List<Cluster> Compute(int centerCount)
        {
            //初始化簇
            List<Cluster> clusters = new List<Cluster>(Pointers.Count);
            foreach (var pointer in Pointers)
            {
                clusters.Add(new Cluster { Pointers = new List<Pointer>() { pointer } });
            }
            while (clusters.Count > centerCount)
            {
                for (int i = 0; i < clusters.Count; i++)
                {
                    if (clusters.Count <= centerCount)
                    {
                        break;
                    }
                    var current = clusters[i];
                    var minDistance = double.MaxValue;
                    var minClusters = new Cluster();
                    for (int j = 0; j < clusters.Count; j++)
                    {
                        var other = clusters[j];
                        if (current == other)
                        {
                            continue;
                        }
                        if (GetDistance(current.Pointers, other.Pointers) < minDistance)
                        {
                            minClusters = other;
                        }
                    }
                    //合并操作
                    current.Pointers.AddRange(minClusters.Pointers);
                    clusters.Remove(minClusters);
                }
            }
            return clusters;
        }
        /// <summary>
        /// 获得距离
        /// </summary>
        /// <param name="currentPointers"></param>
        /// <param name="otherPointers"></param>
        /// <returns></returns>
        private double GetDistance(List<Pointer> currentPointers, List<Pointer> otherPointers)
        {
            //比较中心点距离
            var currentCenter = GetCenter(currentPointers);
            var otherCenter = GetCenter(otherPointers);
            var distance = Math.Pow(currentCenter.X - otherCenter.X, 2)
                           + Math.Pow(currentCenter.Y - otherCenter.Y, 2)
                           + Math.Pow(currentCenter.Z - otherCenter.Z, 2);
            distance = Math.Abs(distance);
            return distance;
        }
        /// <summary>
        /// 获得中心点
        /// </summary>
        /// <param name="pointers"></param>
        /// <returns></returns>
        private Pointer GetCenter(List<Pointer> pointers)
        {
            var center = new Pointer();
            var centerDistance = double.MaxValue;
            foreach (var current in pointers)
            {
                var totalDistance = 0d;
                foreach (var other in pointers)
                {
                    if (current == other)
                    {
                        continue;
                    }
                    var distance = Math.Pow(current.X - other.X, 2)
                                + Math.Pow(current.Y - other.Y, 2)
                                + Math.Pow(current.Z - other.Z, 2);
                    distance = Math.Abs(distance);
                    totalDistance += distance;
                }
                if (totalDistance < centerDistance)
                {
                    center = current;
                }
            }
            return center;
        }
    }
}

