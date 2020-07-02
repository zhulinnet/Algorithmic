using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace algorithmStudy.Services.Clustering
{
    public class Pointer
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }
    public class Cluster
    {
        public Pointer Center { get; set; }
        public List<Pointer> Pointers { get; set; }
        public int IsChange { get; set; }
        public Cluster()
        {
            this.IsChange = 1;
            this.Pointers = new List<Pointer>();
        }
        public void RefreshCenter()
        {
            //计算各个簇中数据的重心，然后将簇的中心点移动到这个位置
            var center = this.Center;
            var minDistance = double.MaxValue;
            foreach (var current in this.Pointers)
            {
                var totalDistance = 0d;
                foreach (var other in this.Pointers)
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
                if (totalDistance < minDistance)
                {
                    center = current;
                }
            }
            if (this.Center == center)
            {
                this.IsChange = 0;
                return;
            }
            this.Center = center;
            this.IsChange = 1;
        }
    }
    public class K_means
    {
        public List<Pointer> Pointers { get; set; }
        public K_means(List<Pointer> pointers)
        {
            this.Pointers = pointers;
        }
        public List<Cluster> Compute(int centerCount)
        {
            List<Cluster> clusters = new List<Cluster>(centerCount);
            Pointers=Pointers.OrderBy(x => x.X).ThenBy(x => x.Y).ThenBy(x => x.Z).ToList();
            //选取centerCount个中心点
            var p = Pointers.Count() / centerCount;
            for (var i = 0; i < centerCount; i++)
            {
                clusters.Add(new Cluster());
                clusters[i].Center = Pointers[p * i];
            }
            //重复执行“将数据分到相应的簇中”和“将中心点移到重心的位置”这两个操作，直到中心点不再发生变化为止
            while (clusters.Sum(cluster => cluster.IsChange) > 0)
            {
                clusters.ForEach(
                    cluster =>
                    {
                        if (!cluster.Pointers.Any()) return;
                        cluster.RefreshCenter();
                        cluster.Pointers.Clear();
                    });
                foreach (var pointer in Pointers)
                {
                    var minDistance = double.MaxValue;
                    var minIndex = 0;
                    for (var i = 0; i < centerCount; i++)
                    {
                        //计算各个数据分别和centerCount个中心点中的哪一个点距离最近
                        var distance = Math.Pow(clusters[i].Center.X - pointer.X, 2)
                                     + Math.Pow(clusters[i].Center.Y - pointer.Y, 2)
                                     + Math.Pow(clusters[i].Center.Z - pointer.Z, 2);
                        distance = Math.Abs(distance);
                        if (distance < minDistance)
                        {
                            minDistance = distance;
                            minIndex = i;
                            if (minDistance == 0)
                            {
                                break;
                            }
                        }
                    }
                    //将数据分到相应的簇中。这样，centerCount个簇的聚类就完成了
                    clusters[minIndex].Pointers.Add(pointer);
                }
            }
            return clusters;
        }
    }
}
