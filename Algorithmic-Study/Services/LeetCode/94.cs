using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _94
    {
        /*
         * 给定一个二叉树，返回它的中序 遍历。

            示例:
            
            输入: [1,null,2,3]
               1
                \
                 2
                /
               3
            
            输出: [1,3,2]
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/binary-tree-inorder-traversal
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
            public IList<int> InorderTraversal(TreeNode root)
            {
                List<int> result = new List<int>();
                InorderTraversal(ref result,root);
                return result;
            }
            public void InorderTraversal(ref List<int> result, TreeNode node)
            {
                if (node == null)
                {
                    return;
                }
                InorderTraversal(ref result, node.left);
                result.Add(node.val);
                InorderTraversal(ref result, node.right);
            }
        }
        public class Solution1
        {
            public IList<int> InorderTraversal(TreeNode root)
            {
                List<int> result = new List<int>();
                Stack<TreeNode> backup = new Stack<TreeNode>();
                while (root != null||backup.Count>0)
                {
                    while (root != null)
                    {
                        backup.Push(root);
                        root = root.left;
                    }
                    root = backup.Pop();
                    result.Add(root.val);
                    root = root.right;
                }
                return result;
            }
        }
    }
}
