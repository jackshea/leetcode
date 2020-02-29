using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 两数相加
    /// https://leetcode-cn.com/problems/add-two-numbers/
    public class P0002_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode fakeHead = new ListNode(0);
            ListNode curr = fakeHead;
            int carry = 0;
            int a = 0;
            int b = 0;
            while (l1 != null || l2 != null)
            {
                a = l1?.val ?? 0;
                b = l2?.val ?? 0;
                int sum = a + b + carry;
                carry = 0;
                if (sum >= 10)
                {
                    sum -= 10;
                    carry = 1;
                }

                curr.next = new ListNode(sum);
                curr = curr.next;

                l1 = l1?.next;
                l2 = l2?.next;
            }

            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }

            return fakeHead.next;
        }
    }
}