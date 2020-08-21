using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。

如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。

您可以假设除了数字 0 之外，这两个数都不会以 0 开头。

来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/add-two-numbers
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
 */
namespace algorithmStudy.Services.LeetCode
{
    class _1
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        /*
         * [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1]
         * [5,6,4]
         * 无法通过
         */
        public class Solution1
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                string result = (GetNum(l1) + GetNum(l2)).ToString("G");
                ListNode l = null;
                ListNode current = null;
                char[] arr = result.ToCharArray();
                foreach (char c in arr.Reverse())
                {
                    if (l == null)
                    {
                        l = new ListNode(Convert.ToInt32(c.ToString()));
                        current = l;
                        continue;
                    }
                    else
                    {

                        current.next = new ListNode(Convert.ToInt32(c.ToString()));
                        current = current.next;
                    }
                }
                return l;
            }
            private void append(int item)
            {
            }
            private double GetNum(ListNode l)
            {
                Stack<int> numbers = new Stack<int>();
                while (l != null)
                {
                    numbers.Push(l.val);
                    l = l.next;
                }
                string strNum = "";
                while (numbers.Count > 0)
                {
                    strNum += numbers.Pop();
                }
                return double.Parse(strNum);
            }
        }
        public class Solution2
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                Queue<int> numbers1 = GetNumbers(l1);
                Queue<int> numbers2 = GetNumbers(l2);
                ListNode l = null, current = null;
                while (numbers1.Count > 0 || numbers2.Count > 0)
                {
                    int number1 = numbers1.Count > 0 ? numbers1.Dequeue() : 0;
                    int number2 = numbers2.Count > 0 ? numbers2.Dequeue() : 0;
                    if (l == null)
                    {
                        int add = number1 + number2;
                        l = new ListNode(add % 10);
                        var ten = add / 10 % 10;
                        if (ten != 0)
                        {
                            l.next = new ListNode(add / 10 % 10);
                        }
                        current = l;
                        continue;
                    }
                    else
                    {
                        int add = number1 + number2+ (current.next!=null?current.next.val:0);
                        current.next = new ListNode(add % 10);
                        var ten = add / 10 % 10;
                        if (ten != 0)
                        {
                            current.next.next = new ListNode(add / 10 % 10);
                        }
                        current = current.next;
                    }
                }
                return l;
            }
            private Queue<int> GetNumbers(ListNode l)
            {
                Queue<int> numbers = new Queue<int>();
                while (l != null)
                {
                    numbers.Enqueue(l.val);
                    l = l.next;
                }
                return numbers;
            }
        }
        public class Solution3
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode l = null, current = null;
                while (l1 != null || l2 != null)
                {
                    int number1 = 0, number2=0;
                    if (l1 != null)
                    {
                        number1 = l1.val;
                        l1 = l1.next;
                    }
                    if (l2 != null)
                    {
                        number2 = l2.val;
                        l2 = l2.next;
                    }
                    if (l == null)
                    {
                        int add = number1 + number2;
                        l = new ListNode(add % 10);
                        var ten = add / 10 % 10;
                        if (ten != 0)
                        {
                            l.next = new ListNode(add / 10 % 10);
                        }
                        current = l;
                        continue;
                    }
                    else
                    {
                        int add = number1 + number2 + (current.next != null ? current.next.val : 0);
                        current.next = new ListNode(add % 10);
                        var ten = add / 10 % 10;
                        if (ten != 0)
                        {
                            current.next.next = new ListNode(add / 10 % 10);
                        }
                        current = current.next;
                    }
                }
                return l;
            }
        }
    }
}
