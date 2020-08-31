using System;
using System.Collections.Generic;
using System.Text;

namespace algorithmStudy.Services.LeetCode.CodingInterviews
{
    class _06
    {
        /*
         * 输入一个链表的头节点，从尾到头反过来返回每个节点的值（用数组返回）。

 

            示例 1：
            
            输入：head = [1,3,2]
            输出：[2,3,1]
             
            
            限制：
            
            0 <= 链表长度 <= 10000
            
            来源：力扣（LeetCode）
            链接：https://leetcode-cn.com/problems/cong-wei-dao-tou-da-yin-lian-biao-lcof
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
            public int[] ReversePrint(ListNode head)
            {
                Stack<int> vals = new Stack<int>();
                while (head != null)
                {
                    vals.Push(head.val);
                    head = head.next;
                }
                int i = 0;
                int[] result = new int[vals.Count];
                while (vals.Count>0)
                {
                    result[i] = vals.Pop();
                    i++;
                }
                return result;
            }
        }
    }
}
