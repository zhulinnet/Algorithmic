

using algorithmStudy.Services.Clustering;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using static algorithmStudy.Services.LeetCode.CodingInterviews._03;

namespace algorithmStudy
{
    class Program
    {
        static void Main()
        {
            //char[][] grid = new char[][]
            //    {
            //        new char[] {'1','1','0','0','0'},
            //        new char[] { '1','1','0','0','0' },
            //        new char[] { '0','0','1','0','0'},
            //        new char[] { '0', '0', '0', '1', '1' }
            //    };
            //Console.WriteLine(new Solution().NumIslands(grid));

            //Console.WriteLine(new Solution().RepeatedSubstringPattern("abababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababa"));
            //Console.WriteLine(new Solution().JudgeCircle("LLUDRR"));
            //Console.WriteLine(new Solution().LetterCombinations("223"));
            //List<List<int>> rooms = new List<List<int>>();
            //rooms.Add(new List<int>() { 1, 3 });
            //rooms.Add(new List<int>() { 3, 0, 1,2 });
            //rooms.Add(new List<int>() { 2,3 });
            ////rooms.Add(new List<int>() { 0 });
            //Console.WriteLine(new Solution().CanVisitAllRooms(rooms));
            Console.WriteLine(new Solution().FindRepeatNumber(new int[] { 2, 3, 4, 2 }));

        }
    }
}

