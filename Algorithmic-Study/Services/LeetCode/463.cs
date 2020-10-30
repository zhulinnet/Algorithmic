using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    public class _463
    {
        /*
         * 给定一个包含 0 和 1 的二维网格地图，其中 1 表示陆地 0 表示水域。

            网格中的格子水平和垂直方向相连（对角线方向不相连）。整个网格被水完全包围，但其中恰好有一个岛屿（或者说，一个或多个表示陆地的格子相连组成的岛屿）。
            
            岛屿中没有“湖”（“湖” 指水域在岛屿内部且不和岛屿周围的水相连）。格子是边长为 1 的正方形。网格为长方形，且宽度和高度均不超过 100 。计算这个岛屿的周长。
            
             
            
            示例 :
            
            输入:
            [[0,1,0,0],
             [1,1,1,0],
             [0,1,0,0],
             [1,1,0,0]]
            
            输出: 16
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/island-perimeter
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            int[][] directions = new int[][]
            {
                    new int[] { 0, -1 },
                    new int[] { 0, 1 },
                    new int[] { 1, 0 },
                    new int[] { -1, 0 }
            };
            public int IslandPerimeter(int[][] grid)
            {
                if (grid == null || grid.Length == 0)
                {
                    return 0;
                }
                int perimeter = 0;
                int n = grid.Length, m = grid[0].Length;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (grid[i][j] == 1)
                        {
                            for (int k = 0; k < 4; k++)
                            {
                                int newX = i+directions[k][0];
                                int newY = j+directions[k][1];
                                if (newX < 0 || newX >= n || newY < 0 || newY >= m || grid[newX][newY] == 0)
                                {
                                    perimeter++;
                                }
                            }
                        }
                    }
                }
                return perimeter;
            }
        }
    }
}
