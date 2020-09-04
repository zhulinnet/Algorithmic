using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _12
    {
        /*
         * n 皇后问题研究的是如何将 n 个皇后放置在 n×n 的棋盘上，并且使皇后彼此之间不能相互攻击。



            上图为 8 皇后问题的一种解法。
            
            给定一个整数 n，返回所有不同的 n 皇后问题的解决方案。
            
            每一种解法包含一个明确的 n 皇后问题的棋子放置方案，该方案中 'Q' 和 '.' 分别代表了皇后和空位。
            
             
            
            示例：
            
            输入：4
            输出：[
             [".Q..",  // 解法 1
              "...Q",
              "Q...",
              "..Q."],
            
             ["..Q.",  // 解法 2
              "Q...",
              "...Q",
              ".Q.."]
            ]
            解释: 4 皇后问题存在两个不同的解法。
             
            
            提示：
            
            皇后彼此不能相互攻击，也就是说：任何两个皇后都不能处于同一条横行、纵行或斜线上。
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/n-queens
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            int[] queen = null;
            IList<IList<string>> result = new List<IList<string>>();
            public IList<IList<string>> SolveNQueens(int n)
            {
                queen = new int[n];
                backTracking(n);
                return result;
            }
            private bool isOk(int row)
            {
                for (int j = 0; j < row; j++)
                {
                    if (queen[row] == queen[j] || row - queen[row] == j - queen[j] || row + queen[row] == j + queen[j])
                        return false;
                }
                return true;
            }
            private void backTracking(int n, int row = 0)
            {
                if (n == row)
                {
                    List<string> list = new List<string>();
                    bool flag = true;
                    foreach (var item in queen)
                    {
                        if (item == 0)
                        {
                            flag = false;
                            break;
                        }
                        StringBuilder sb = new  StringBuilder ();
                        for (int i = 1; i <=n; i++)
                        {
                            if (i == item)
                            {
                                sb.Append("Q");
                            }
                            else 
                            {
                                sb.Append(".");
                            }
                        }
                        list.Add(sb.ToString());
                    }
                    if (flag)
                    {
                        result.Add(list);
                    }          
                    queen = new int[n];
                    return;
                }
                for (int col = 1; col <= n; col++)
                {
                    queen[row] = col;
                    if (isOk(row))
                    {
                        backTracking(n,row+1);
                    }
                }
            }
        }
    }
}
