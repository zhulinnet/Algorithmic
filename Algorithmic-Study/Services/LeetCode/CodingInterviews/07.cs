using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace algorithmStudy.Services.LeetCode.CodingInterviews
{
    class _07
    {
        /*
         * 输入某二叉树的前序遍历和中序遍历的结果，请重建该二叉树。假设输入的前序遍历和中序遍历的结果中都不含重复的数字。

 

            例如，给出

            前序遍历 preorder = [3,9,20,15,7]
            中序遍历 inorder = [9,3,15,20,7]
            返回如下的二叉树：
            
                3
               / \
              9  20
                /  \
               15   7
             
            
            限制：
            
            0 <= 节点个数 <= 5000
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/zhong-jian-er-cha-shu-lcof
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
            private int inIndex = 0;
            private int preIndex = 0;

            public TreeNode BuildTree(int[] preorder, int[] inorder)
            {
                return build(preorder, inorder, Int32.MinValue);
            }

            private TreeNode build(int[] preorder, int[] inorder, int stop)
            {
                if (preIndex >= preorder.Length)
                    return null;
                if (inorder[inIndex] == stop)
                {
                    inIndex++;
                    return null;
                }

                TreeNode node = new TreeNode(preorder[preIndex++]);
                node.left = build(preorder, inorder, node.val);
                node.right = build(preorder, inorder, stop);
                return node;
            }

        }
    }
}
