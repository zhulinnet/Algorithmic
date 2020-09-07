/************************************************************************************
 *
 * 给定一个二叉树，返回其节点值自底向上的层次遍历。 （即按从叶子节点所在层到根节点所在的层，逐层从左向右遍历）

    例如：
    给定二叉树 [3,9,20,null,null,15,7],
    
        3
       / \
      9  20
        /  \
       15   7
    返回其自底向上的层次遍历为：
    
    [
      [15,7],
      [9,20],
      [3]
    ]
    
    来源：力扣（LeetCode）
    链接：https://leetcode-cn.com/problems/binary-tree-level-order-traversal-ii
    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 * 
 ************************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    class _107
    {


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public class Solution
        {
            public IList<IList<int>> LevelOrderBottom(TreeNode root)
            {
                Stack<IList<int>> backup = new Stack<IList<int>>();
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    int num = queue.Count;
                    IList<int> list = new List<int>();
                    for (int i = 0; i < num; ++i)
                    {
                        TreeNode cur = queue.Peek();
                        if (cur != null)
                        {
                            list.Add(cur.val);
                            queue.Enqueue(cur.left);
                            queue.Enqueue(cur.right);
                        }
                        queue.Dequeue();
                    }
                    if (list.Count > 0)
                        backup.Push(list);
                }
                return backup.ToArray();
            }
        }
        public class Solution1
        {
            public IList<IList<int>> LevelOrderBottom(TreeNode root)
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                Stack<IList<int>> backup = new Stack<IList<int>>();
                BFS(root, ref backup, ref queue);
                return backup.ToArray();
            }
            private void BFS(TreeNode root, ref Stack<IList<int>> backup, ref Queue<TreeNode> queue)
            {
                if (root == null)
                {
                    return;
                }
                queue.Enqueue(root);
                do
                {
                    int num = queue.Count;
                    IList<int> list = new List<int>();
                    for (int i = 0; i < num; ++i)
                    {
                        TreeNode cur = queue.Dequeue();
                        if (cur != null)
                        {
                            list.Add(cur.val);
                            queue.Enqueue(cur.left);
                            queue.Enqueue(cur.right);
                        }
                    }
                    if (list.Count > 0)
                        backup.Push(list);
                }
                while (queue.Count > 0);
            }
        }
    }
}
