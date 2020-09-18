using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _47
    {
        /*
         * 给定一个可包含重复数字的序列，返回所有不重复的全排列。

            示例:
            
            输入: [1,1,2]
            输出:
            [
              [1,1,2],
              [1,2,1],
              [2,1,1]
            ]
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/permutations-ii
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public IList<IList<int>> PermuteUnique(int[] nums)
            {
                HashSet<IList<int>> res = new HashSet<IList<int>>();
                Stack<int> path = new Stack<int>();
                bool[] userd = new bool[nums.Length];
                DFS(nums, userd, path, res);
                return res.ToList();
            }
            private void DFS(int[] nums, bool[] userd, Stack<int> path, HashSet<IList<int>> res)
            {
                if (nums.Length == path.Count)
                {
                    var current = path.ToArray();
                    res.Add(current);
                    return;
                }
                for (int i = 0; i < nums.Length; i++)
                {
                    if (userd[i])
                    {
                        continue;
                    }
                    userd[i] = true;
                    path.Push(nums[i]);
                    DFS(nums, userd, path, res);
                    path.Pop();
                    userd[i] = false;
                }
            }
        }
    }
}
