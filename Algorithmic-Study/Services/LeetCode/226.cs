using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _226
    {
        /*
         * 226. 翻转二叉树
        翻转一棵二叉树。
        
        示例：
        
        输入：

             4
           /   \
          2     7
         / \   / \
        1   3 6   9
        输出：
        
             4
           /   \
          7     2
         / \   / \
        9   6 3   1
        备注:
        这个问题是受到 Max Howell 的 原问题 启发的 ：
        
        谷歌：我们90％的工程师使用您编写的软件(Homebrew)，但是您却无法在面试时在白板上写出翻转二叉树这道题，这太糟糕了。
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
            public TreeNode InvertTree(TreeNode root)
            {
                if (root == null)
                {
                    return root;
                }
                if (root.left == null && root.right == null)
                {
                    return root;
                }
                TreeNode right = root.right;
                TreeNode left = root.left;
                root.left = InvertTree(right);
                root.right = InvertTree(left);
                return root;
            }

        }
        public class Solution1
        {
            public TreeNode InvertTree(TreeNode root)
            {
                if (root == null)
                {
                    return root;
                }
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                while (queue.Count> 0)
                {
                    TreeNode current = queue.Dequeue();
                    TreeNode right = current.right;
                    TreeNode left = current.left;
                    current.right = left;
                    current.left = right;
                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }
                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }
                }
                return root;
            }

        }
    }
}
