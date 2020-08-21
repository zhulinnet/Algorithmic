using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _4
    {
        /*
         * 给你一个由 '1'（陆地）和 '0'（水）组成的的二维网格，请你计算网格中岛屿的数量。

            岛屿总是被水包围，并且每座岛屿只能由水平方向或竖直方向上相邻的陆地连接形成。
            
            此外，你可以假设该网格的四条边均被水包围。

        示例 1:
        
        输入:
        [
        ['1','1','1','1','0'],
        ['1','1','0','1','0'],
        ['1','1','0','0','0'],
        ['0','0','0','0','0']
        ]
        输出: 1
        示例 2:
        
        输入:
        [
        ['1','1','0','0','0'],
        ['1','1','0','0','0'],
        ['0','0','1','0','0'],
        ['0','0','0','1','1']
        ]
        输出: 3
        解释: 每座岛屿只能由水平和/或竖直方向上相邻的陆地连接而成。
        
        来源：力扣（LeetCode）
        链接：https://leetcode-cn.com/problems/number-of-islands
        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public int NumIslands(char[][] grid)
            {
                if (grid == null || grid.Length == 0)
                {
                    return 0;
                }
                int islandsNum = 0;
                for (int i = 0; i < grid.Length; i++)
                {
                    for (int j = 0; j < grid[i].Length; j++)
                    {
                        var current = grid[i][j];
                        if (current == '1' && current != '0')
                        {
                            islandsNum++;
                            DFS(grid, i, j);
                        }
                    }
                }
                return islandsNum;
            }
            int[][] directions = new int[][]
              {
                    new int[] { 0, -1 },
                    new int[] { 0, 1 },
                    new int[] { 1, 0 },
                    new int[] { -1, 0 }
              };
            private void DFS(char[][] grid, int x, int y)
            {
                int n = grid.Length, m = grid[0].Length;
                if (x < 0 || x >= n || y < 0 || y >= m || grid[x][y] == '2' || grid[x][y] == '0')
                return;
                grid[x][y] = '0';
                for (int k = 0; k < 4; k++)
                {
                    int newX = x + directions[k][0];
                    int newY = y + directions[k][1];
                    DFS(grid, newX, newY);
                }
            }
        }
    }
}
