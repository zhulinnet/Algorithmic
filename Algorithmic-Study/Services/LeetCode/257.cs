using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _257
    {
        /*
         * 给定一个二叉树，返回所有从根节点到叶子节点的路径。

        说明: 叶子节点是指没有子节点的节点。

        示例:
        
        输入:
        
           1
         /   \
        2     3
         \
          5
        
        输出: ["1->2->5", "1->3"]
        
        解释: 所有根节点到叶子节点的路径为: 1->2->5, 1->3
        
        来源：力扣（LeetCode）
        链接：https://leetcode-cn.com/problems/binary-tree-paths
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
            public IList<string> BinaryTreePaths(TreeNode root)
            {
                List<string> path = new List<string>();
                StringBuilder pathStr = new StringBuilder();
                DFS(root, ref path, "");
                return path;
            }
            public void DFS(TreeNode root, ref List<string> path,string pathStr)
            {
                if (root == null)
                {
                    return;
                }
                StringBuilder sb=new StringBuilder(pathStr);
                sb.Append(root.val);
                if (root.left == null && root.right == null)
                {
                    path.Add(sb.ToString());
                }
                else 
                {
                    sb.Append("->");
                    DFS(root.left, ref path, sb.ToString());
                    DFS(root.right, ref path, sb.ToString());
                }
            }
        }
    }
}
