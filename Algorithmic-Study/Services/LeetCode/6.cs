using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _6
    {
        /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

        /*
         * 给定一个二叉树，找出其最小深度。

       最小深度是从根节点到最近叶子节点的最短路径上的节点数量。

       说明: 叶子节点是指没有子节点的节点。

       示例:

       给定二叉树 [3,9,20,null,null,15,7],

           3
          / \
         9  20
           /  \
          15   7
       返回它的最小深度  2.

       来源：力扣（LeetCode）
       链接：https://leetcode-cn.com/problems/minimum-depth-of-binary-tree
       著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
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
            public int MinDepth(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }
                Queue<TreeNode> children = new Queue<TreeNode>();
                children.Enqueue(root);
                int minDepth = 1;
                while (children != null && children.Count > 0)
                {
                    var count = children.Count;
                    for (int i = 0; i < count; i++)
                    {
                        var node = children.Dequeue();
                        if (node.right == null && node.left == null)
                        {
                            return minDepth;
                        }
                        if (node.left != null)
                        {
                            children.Enqueue(node.left);
                        }
                        if (node.right != null)
                        {
                            children.Enqueue(node.right);
                        }
                    }
                    minDepth++;
                }
                return minDepth;
            }
        }
    }
}
