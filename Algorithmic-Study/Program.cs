

using algorithmStudy.Services.Clustering;
using System;
using System.Collections.Generic;
using System.Linq;
using static algorithmStudy.Services.LeetCode._4;

namespace algorithmStudy
{
    class Program
    {
        static void Main()
        {
            char[][] grid = new char[][]
                {
                    new char[] {'1','1','0','0','0'},
                    new char[] { '1','1','0','0','0' },
                    new char[] { '0','0','1','0','0'},
                    new char[] { '0', '0', '0', '1', '1' }
                };
            Console.WriteLine(new Solution().NumIslands(grid));
        }
    }
}

