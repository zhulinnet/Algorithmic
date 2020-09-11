using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _216
    {
        /*
         * 找出所有相加之和为 n 的 k 个数的组合。组合中只允许含有 1 - 9 的正整数，并且每种组合中不存在重复的数字。

            说明：
            
            所有数字都是正整数。
            解集不能包含重复的组合。 
            示例 1:
            
            输入: k = 3, n = 7
            输出: [[1,2,4]]
            示例 2:
            
            输入: k = 3, n = 9
            输出: [[1,2,6], [1,3,5], [2,3,4]]
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/combination-sum-iii
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public IList<IList<int>> CombinationSum3(int k, int n)
            {
                IList<IList<int>> res = new List<IList<int>>();
                if (n <= 0)
                {
                    return res;
                }
                Stack<int> path = new Stack<int>();
                DFS(k, n, 1, path, res);
                return res;
            }
            private void DFS(int k, int n, int begin, Stack<int> path, IList<IList<int>> res)
            {
                if (n == 0)
                {
                    if (path.Count == k)
                    {
                        res.Add(path.ToArray());
                    }
                    return;
                }
                for (int i = begin; i < 10; i++)
                {
                    if (n - i < 0)
                    {
                        break;
                    }
                    path.Push(i);
                    DFS(k, n - i, i + 1, path, res);
                    path.Pop();
                }
            }
        }
    }
}
