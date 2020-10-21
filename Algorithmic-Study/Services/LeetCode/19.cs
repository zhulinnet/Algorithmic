using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    public class _19
    {
        /*
         * 给定一个链表，删除链表的倒数第 n 个节点，并且返回链表的头结点。

            示例：
            
            给定一个链表: 1->2->3->4->5, 和 n = 2.
            
            当删除了倒数第二个节点后，链表变为 1->2->3->5.
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/remove-nth-node-from-end-of-list
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
            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                int length = GetLength(head);
                int m = length - n;
                ListNode current = head;
                ListNode prev = null;
                int index = 0;
                if (m == 0)
                {
                    head = head.next;
                    return head;
                }
                while (current != null)
                {
                    if(m==index)
                    {
                        prev.next = current.next;
                    }
                    index++;
                    prev = current;
                    current = current.next;
                }
                return head;
            }
            private int GetLength(ListNode node)
            {
                int length = 0;
                while (node != null)
                {
                    length++;
                    node = node.next;
                }
                return length;
            }

        }

    }
}
