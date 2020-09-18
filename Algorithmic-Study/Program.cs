

using algorithmStudy.Services.Clustering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using static algorithmStudy.Services.LeetCode._47;
//using static algorithmStudy.Services.LeetCode.CodingInterviews._58;

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

            //Console.WriteLine(new Solution1().RepeatedSubstringPattern("abacababacaba"));
            //Console.WriteLine(new Solution().JudgeCircle("LLUDRR"));
            //Console.WriteLine(new Solution().LetterCombinations("223"));
            //List<List<int>> rooms = new List<List<int>>();
            //rooms.Add(new List<int>() { 1, 3 });
            //rooms.Add(new List<int>() { 3, 0, 1,2 });
            //rooms.Add(new List<int>() { 2,3 });
            ////rooms.Add(new List<int>() { 0 });
            //Console.WriteLine(new Solution().CanVisitAllRooms(rooms));
            //Console.WriteLine(new Solution().BuildTree(new int[] { 3, 9, 20, 15, 7 }, new int[] { 9, 3, 15, 20, 7 }));
            //1, 5, 2, 33, 41, 5, 8, 9, 0
            //Console.WriteLine(new Solution1().PredictTheWinner(new int[] { 1, 5, 2,4,6 }));
            //Console.WriteLine(new Solution().IsNumber("4e+"));
            //Console.WriteLine(new Solution().ThirdMax(new int[] { 1, 2 }));
            //Console.WriteLine(new Solution1().Reverse(-2133333333));
            //TreeNode root = new TreeNode(3);
            //root.left = new TreeNode(9);
            //root.left.left = new TreeNode(1);
            //root.right = new TreeNode(20);
            //root.right.left = new TreeNode(15);
            //root.right.right = new TreeNode(7);
            //root.right.left.left= new TreeNode(15);
            //root.right.left.right = new TreeNode(7);
            //root.right.left = new TreeNode(1);
            //Console.WriteLine(new Solution1().LevelOrderBottom(root));
            //Console.WriteLine(new Solution().TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 },2));
            //Console.WriteLine(new Solution().IsValid("{{{}}}"));
            //Console.WriteLine(new Solution().Combine(4,2));
            //var bits = new BitArray(3);
            //bits[1] = true;
            //bits[2] = true;
            //bits[0] = true;
            //var bits1 = new BitArray(3);
            //bits1[1] = true;
            //bits1[2] = true;
            //bits1[0] = false;
            //bits.Xor(bits1);                 // Bitwise exclusive-OR bits with itself
            //Console.WriteLine(bits[1]);     // False

            //Console.WriteLine(new Solution().CombinationSum2(new int[] { 2, 5, 2, 1, 2 }, 5));
            //TreeNode root = new TreeNode(2147483647);
            //root.left = new TreeNode(2147483647);
            //root.right = new TreeNode(2147483647);
            //Console.WriteLine(new Solution().AverageOfLevels(root));
            //Console.WriteLine(new Solution().HammingDistance(2,4));
            //Console.WriteLine(new Solution1().ReverseLeftWords("abcdefg",2));
            Console.WriteLine(new Solution().PermuteUnique(new int[] { 1,2,1 }));
            //Console.WriteLine(new Solution().Exist(new char[][] {new char[]{  'C', 'A','A' }, new char[] { 'A', 'A', 'A' }, new char[] { 'B', 'C', 'D'} }, "AAB"));
        }
    }
}

