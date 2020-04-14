using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    public class P0445_AddTwoNumbersII
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            Stack<int> s1 = new Stack<int>();
            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
            }

            Stack<int> s2 = new Stack<int>();
            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }

            int carry = 0;
            ListNode ans = null;
            while (s1.Count != 0 || s2.Count != 0 || carry != 0)
            {
                int a = 0, b = 0;
                if (s1.Count != 0)
                {
                    a = s1.Pop();
                }
                if (s2.Count != 0)
                {
                    b = s2.Pop();
                }

                int sum = a + b + carry;
                carry = sum > 9 ? 1 : 0;

                ListNode cur = new ListNode(sum % 10);
                cur.next = ans;
                ans = cur;
            }

            return ans;
        }
    }
}