using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _5
    {
        /*
         *给定一棵二叉树，想象自己站在它的右侧，按照从顶部到底部的顺序，返回从右侧所能看到的节点值。

            示例:
            
            输入: [1,2,3,null,5,null,4]
            输出: [1, 3, 4]
            解释:
            
               1            <---
             /   \
            2     3         <---
             \     \
              5     4       <---
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/binary-tree-right-side-view
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。。
         */
        /**
        * Definition for a binary tree node.
        * public class TreeNode {
        *     public int val;
        *     public TreeNode left;
        *     public TreeNode right;
        *     public TreeNode(int x) { val = x; }
        * }
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
            public IList<int> RightSideView(TreeNode root)
            {
                List<int> result = new List<int>();
                SearchRight(ref result,root);
                return result;
            }
            List<int> levels = new List<int>();
            private void SearchRight(ref List<int> result, TreeNode root,int level=0)
            {
                if (root == null)
                {
                    return;
                }
                if (!levels.Contains(level))
                {
                    levels.Add(level);
                    result.Add(root.val);
                }
                level++;
                SearchRight(ref result, root.right, level);
                SearchRight(ref result, root.left, level);
                
            }
        }
    }
}
