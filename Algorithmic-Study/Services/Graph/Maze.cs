using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace algorithmStudy.Services.Graph
{
    public class MazePointer
    {
        /// <summary>
        /// 横坐标
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// 纵坐标
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// 从起点到当前坐标的距离
        /// </summary>
        public int H { get; set; } = 0;
        /// <summary>
        /// 距离估算值
        /// </summary>
        public int W { get; set; } = 0;
        public MazePointer Father { get; set; }

    }
    public class Maze
    {
        /// <summary>
        /// 已访问过的坐标集合
        /// </summary>
        private List<MazePointer> VisitedList { get; set; }
        /// <summary>
        /// 待访问的坐标集合
        /// </summary>
        private List<MazePointer> BackUpList { get; set; }
        public string[,] MazeGraph { get; set; }
        public Maze(string[,] mazeGraph)
        {
            this.MazeGraph = mazeGraph;
            VisitedList = new List<MazePointer>();
            BackUpList = new List<MazePointer>();
        }
        public void AStar(MazePointer start, MazePointer end)
        {
            MazePointer initPointer(int x, int y)
            {
                return new MazePointer()
                {
                    X = x,
                    Y = y,
                    Father = start,
                    W = GetW(end.X - x, end.Y - y),
                    H = start.H + 1
                };
            }
            if (start == null || start.Equals(end))
            {
                return;
            }
            VisitedList.Add(start);
            BackUpList.Remove(start);
            //找到strat周围的点
            MazePointer current = null, top = null, bottom = null, left = null, right = null;
            if (start.Y - 1 >= 0)
            {
                if (MazeGraph[start.X, start.Y - 1] != null)
                {
                    top = initPointer(start.X, start.Y - 1);
                    if (VisitedList.Exists(x => x.X == top.X && x.Y == top.Y))
                    {
                        top = null;
                    }
                    if (top != null)
                    {
                        BackUpList.Add(top);
                    }
                    current = top;
                }
            }
            if (start.Y + 1 < MazeGraph.GetLength(1))
            {
                if (MazeGraph[start.X, start.Y + 1] != null)
                {
                    bottom = initPointer(start.X, start.Y + 1);
                    if (VisitedList.Exists(x => x.X == bottom.X && x.Y == bottom.Y))
                    {
                        bottom = null;
                    }
                    if (bottom != null)
                    {
                        BackUpList.Add(bottom);
                    }
                    current = GetShorter(current, bottom);
                }
            }
            if (start.X - 1 >= 0)
            {
                if (MazeGraph[start.X - 1, start.Y] != null)
                {
                    left = initPointer(start.X - 1, start.Y);
                    if (VisitedList.Exists(x => x.X == left.X && x.Y == left.Y))
                    {
                        left = null;
                    }
                    if (left != null)
                    {
                        BackUpList.Add(left);
                    }
                    current = GetShorter(current, left);
                }
            }
            if (start.X + 1 < MazeGraph.GetLength(0))
            {
                if (MazeGraph[start.X + 1, start.Y] != null)
                {
                    right = initPointer(start.X + 1, start.Y);
                    if (VisitedList.Exists(x => x.X == right.X && x.Y == right.Y))
                    {
                        right = null;
                    }
                    if (right != null)
                    {
                        BackUpList.Add(right);
                    }
                    current = GetShorter(current, right);
                }
            }
            foreach (var backup in BackUpList)
            {
                current = GetShorter(current, backup);
            }
            AStar(current, end);
        }
        /// <summary>
        /// 读取最短路径
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="start">开始</param>
        /// <param name="end">结束</param>
        public void GetShortest(ref List<string> path, MazePointer start, MazePointer end)
        {
            if (end.X == start.X && end.Y == start.Y)
            {
                path.Add(MazeGraph[end.X, end.Y]);
                return;
            }
            var endPointer = VisitedList.FirstOrDefault(x => x.X == end.X && x.Y == end.Y);
            path.Add(MazeGraph[endPointer.X, endPointer.Y]);
            GetShortest(ref path, start, endPointer.Father);
        }
        /// <summary>
        /// 判断是否更短
        /// </summary>
        /// <param name="current"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        private MazePointer GetShorter(MazePointer current, MazePointer next)
        {
            if (current == null)
            {
                return next;
            }
            if (next == null)
            {
                return current;
            }
            if (current.H + current.W <= next.H + next.W)
            {
                return current;
            }
            return next;
        }
        /// <summary>
        /// 计算距离估算值
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int GetW(int a, int b)
        {
            return (int)Math.Sqrt(a * a + b * b);
        }


    }
}
