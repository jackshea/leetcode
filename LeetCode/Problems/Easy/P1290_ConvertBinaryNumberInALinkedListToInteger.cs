namespace LeetCode.Problems.Easy
{
    /// 二进制链表转整数
    /// https://leetcode-cn.com/problems/convert-binary-number-in-a-linked-list-to-integer/
    public class P1290_ConvertBinaryNumberInALinkedListToInteger
    {
        public int GetDecimalValue(ListNode head)
        {
            int ans = 0;
            ListNode cur = head;
            while (cur != null)
            {
                ans <<= 1;
                ans += cur.val;
                cur = cur.next;
            }

            return ans;
        }
    }
}