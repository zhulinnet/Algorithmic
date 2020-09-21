using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    public class _538
    {
        /*
         * 给定一个二叉搜索树（Binary Search Tree），把它转换成为累加树（Greater Tree)，使得每个节点的值是原来的节点值加上所有大于它的节点值之和。

 
            
            例如：
            
            输入: 原始二叉搜索树:
                          5
                        /   \
                       2     13
            
            输出: 转换为累加树:
                         18
                        /   \
                      20     13
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/convert-bst-to-greater-tree
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
             int num = 0;
            public TreeNode ConvertBST(TreeNode root)
            {
                if (root == null)
                {
                    return null;
                }
                if (root.left == null && root.right == null)
                {
                    return null;
                }
                ConvertBST(root.right);
                root.val = root.val + num;
                num = root.val;
                ConvertBST(root.left);
                return root;
            }
        }
    }
}
