using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _79
    {
        /*
         * 给定一个二维网格和一个单词，找出该单词是否存在于网格中。

            单词必须按照字母顺序，通过相邻的单元格内的字母构成，其中“相邻”单元格是那些水平相邻或垂直相邻的单元格。同一个单元格内的字母不允许被重复使用。
            
             
            
            示例:
            
            board =
            [
              ['A','B','C','E'],
              ['S','F','C','S'],
              ['A','D','E','E']
            ]
            
            给定 word = "ABCCED", 返回 true
            给定 word = "SEE", 返回 true
            给定 word = "ABCB", 返回 false
             
            
            提示：
            
            board 和 word 中只包含大写和小写英文字母。
            1 <= board.length <= 200
            1 <= board[i].length <= 200
            1 <= word.length <= 10^3
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/word-search
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public class Solution
        {
            public bool Exist(char[][] board, string word)
            {
                char[] words = word.ToCharArray();
                for (int i = 0; i < board.Length; i++)
                {
                    for (int j = 0; j < board[i].Length; j++)
                    {
                        var current = board[i][j];
                        if (current == words[0])
                        {
                            if (DFS(board, i, j, words, 0))
                            {
                                return true;
                            }   
                        }
                    }
                }
                return false;
            }
            int[][] directions = new int[][]
              {
                    new int[] { 0, -1 },
                    new int[] { 0, 1 },
                    new int[] { 1, 0 },
                    new int[] { -1, 0 }
              };
            private bool DFS(char[][] board, int x, int y,char[] words,int wordIndex)
            {
                if (wordIndex == words.Length)
                {
                    return true;
                }
                int n = board.Length, m = board[0].Length;
                if (x < 0 || x >= n || y < 0 || y >= m)
                {
                    return false;
                }
                if (words[wordIndex] != board[x][y])
                {
                    return false;
                }
                char backup = board[x][y];
                board[x][y] = '\0';
                bool flag = true;
                for (int k = 0; k < 4; k++)
                {
                    int newX = x + directions[k][0];
                    int newY = y + directions[k][1];
                    flag= DFS(board, newX, newY, words, wordIndex+1);
                    if (flag)
                    {
                        break;
                    }
                }
                board[x][y] = backup;
                return flag;
            }
        }
    }
}
