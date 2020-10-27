using algorithmStudy.Models.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    public class _144
    {
        /*
         * 给定一个二叉树，返回它的 前序 遍历。
        
         示例:
        
        输入: [1,null,2,3]  
           1
            \
             2
            /
           3 
        
        输出: [1,2,3]
        进阶: 递归算法很简单，你可以通过迭代算法完成吗？
        
        来源：力扣（LeetCode）
        链接：https://leetcode-cn.com/problems/binary-tree-preorder-traversal
        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public class Solution
        {
            public IList<int> PreorderTraversal(TreeNode root)
            {
                IList<int> result = new List<int>();
                PreorderTraversal(root, ref result);
                return result;
            }
            private void PreorderTraversal(TreeNode root, ref IList<int> result)
            {
                if (root == null)
                {
                    return;
                }
                result.Add(root.val);
                PreorderTraversal(root.left, ref result);
                PreorderTraversal(root.right, ref result);
            }
        }
        public class Solution1
        {
            public IList<int> PreorderTraversal(TreeNode root)
            {
                IList<int> result = new List<int>();
                if (root == null)
                {
                    return result;
                }
                Stack<TreeNode> backup = new Stack<TreeNode>();
                TreeNode node = root;
                while (backup.Count > 0 || node != null)
                {
                    while (node != null)
                    {
                        result.Add(node.val);
                        backup.Push(node);
                        node = node.left;
                    }
                    node = backup.Pop();
                    node = node.right;
                }
                return result;
            }
        }
    }
}
