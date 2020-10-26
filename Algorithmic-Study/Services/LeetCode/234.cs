using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace algorithmStudy.Services.LeetCode
{
    public class _234
    {
        /*
         * 请判断一个链表是否为回文链表。

            示例 1:
            
            输入: 1->2
            输出: false
            示例 2:
            
            输入: 1->2->2->1
            输出: true
            进阶：
            你能否用 O(n) 时间复杂度和 O(1) 空间复杂度解决此题？
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/palindrome-linked-list
            著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public class Solution
        {
            public bool IsPalindrome(ListNode head)
            {
                List<int> list = new List<int>();
                while (head != null)
                {
                    list.Add(head.val);
                    head = head.next;
                }
                if (list.Count % 2 != 0)
                {
                    return false;
                }
                int i = 0, j = list.Count - 1;
                while (i < j)
                {
                    if (list[i] != list[j])
                    {
                        return false;
                    }
                    i++;
                    j--;
                }
                return true;
            }
        }

        public class Solution1
        {
            public bool IsPalindrome(ListNode head)
            {
                if (head == null)
                {
                    return true;
                }
                ListNode firstHalfEnd = endOfFirstHalf(head);
                ListNode secondHalfStart = reverseList(firstHalfEnd.next);
                ListNode p1 = head;
                ListNode p2 = secondHalfStart;
                bool result = true;
                while (result && p2 != null)
                {
                    if (p1.val != p2.val)
                    {
                        result = false;
                    }
                    p1 = p1.next;
                    p2 = p2.next;
                }

                // 还原链表并返回结果
                firstHalfEnd.next = reverseList(secondHalfStart);
                return result;
            }
            private ListNode endOfFirstHalf(ListNode head)
            {
                ListNode fast = head;
                ListNode slow = head;
                while (fast.next != null && fast.next.next != null)
                {
                    fast = fast.next.next;
                    slow = slow.next;
                }
                return slow;
            }
            private ListNode reverseList(ListNode head)
            {
                ListNode prev = null;
                ListNode curr = head;
                while (curr != null)
                {
                    ListNode nextTemp = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = nextTemp;
                }
                return prev;
            }
        }
    }
}
