using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _3
    {
        /*
         * 统计有序矩阵中的负数
         * 示例 1：

            输入：grid = [[4,3,2,-1],[3,2,1,-1],[1,1,-1,-2],[-1,-1,-2,-3]]
            输出：8
            解释：矩阵中共有 8 个负数。
            示例 2：
            
            输入：grid = [[3,2],[1,0]]
            输出：0
            示例 3：
            
            输入：grid = [[1,-1],[-1,-1]]
            输出：3
            示例 4：
            
            输入：grid = [[-1]]
            输出：1


         */
        public class Solution
        {
            public int CountNegatives(int[][] grid)
            {
                return grid.Sum(s=>s.Count(t=>t<0));
            }
        }
    }
}
