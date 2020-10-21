using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    public class _143
    {
        /*
         * 给定一个单链表 L：L0→L1→…→Ln-1→Ln ，
            将其重新排列后变为： L0→Ln→L1→Ln-1→L2→Ln-2→…
            
            你不能只是单纯的改变节点内部的值，而是需要实际的进行节点交换。
            
            示例 1:
            
            给定链表 1->2->3->4, 重新排列为 1->4->2->3.
            示例 2:
            
            给定链表 1->2->3->4->5, 重新排列为 1->5->2->4->3.
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/reorder-list
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */


        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class Solution
        {
            public void ReorderList(ListNode head)
            {
                List<ListNode> listNodes = GetList(head);
                int i = 0, j = listNodes.Count - 1;
                if (j > 0)
                {
                    while (i < j)
                    {
                        listNodes[i].next = listNodes[j];
                        i++;
                        if (i == j)
                        {
                            break;
                        }
                        listNodes[j].next = listNodes[i];
                        j--;
                    }
                    listNodes[i].next = null;
                }
            }
            private List<ListNode> GetList(ListNode node)
            {
                List<ListNode> listNodes = new List<ListNode>();
                while (node != null)
                {
                    listNodes.Add(node);
                    node = node.next;
                }
                return listNodes;
            }
        }
    }
}
