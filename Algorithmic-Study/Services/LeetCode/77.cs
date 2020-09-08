using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _77
    {
        /*
         * 给定两个整数 n 和 k，返回 1 ... n 中所有可能的 k 个数的组合。

            示例:
            
            输入: n = 4, k = 2
            输出:
            [
              [2,4],
              [3,4],
              [2,3],
              [1,2],
              [1,3],
              [1,4],
            ]
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/combinations
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            
            public IList<IList<int>> Combine(int n, int k)
            {
                IList<IList<int>> res = new List<IList<int>>();
                if (k <= 0 || n < k)
                {
                    return res;
                }
                Stack<int> path = new Stack<int>();
                DFS(n, k, 1,path,res);
                return res;
            }
            private void DFS(int n, int k, int begin, Stack<int> path, IList<IList<int>> res)
            {
                if (path.Count == k)
                {
                    res.Add(path.ToArray());
                    return;
                }
                for (int i = begin; i <= n; i++)
                {
                    path.Push(i);
                    DFS(n, k, i + 1, path, res);
                    path.Pop();
                }
            }
        }
    }
}
