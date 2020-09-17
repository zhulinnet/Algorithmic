using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _637
    {
        /*
         * 
            给定一个非空二叉树, 返回一个由每层节点平均值组成的数组。
            
             
            
            示例 1：
            
            输入：
                3
               / \
              9  20
                /  \
               15   7
            输出：[3, 14.5, 11]
            解释：
            第 0 层的平均值是 3 ,  第1层是 14.5 , 第2层是 11 。因此返回 [3, 14.5, 11] 。
             
            
            提示：
            
            节点值的范围在32位有符号整数范围内。
         */

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public class Solution
        {
            public IList<double> AverageOfLevels(TreeNode root)
            {
                IList<double> backup = new List<double>();
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    int num = queue.Count;
                    double total = 0;
                    double count = 0;
                    for (int i = 0; i < num; ++i)
                    {
                        TreeNode cur = queue.Peek();
                        if (cur != null)
                        {
                            total += cur.val;
                            count++;
                            queue.Enqueue(cur.left);
                            queue.Enqueue(cur.right);
                        }
                        queue.Dequeue();
                    }
                    if (count != 0)
                    {
                        backup.Add(total / count);
                    }
                    
                }
                return backup;
            }
        }
    }
}
