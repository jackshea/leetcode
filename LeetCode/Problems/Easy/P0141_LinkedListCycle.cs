using LeetCode.Common;

namespace LeetCode.Problems.Easy
{
    /// 环形链表
    /// https://leetcode-cn.com/problems/linked-list-cycle/description/
    public class P0141_LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
            {
                return false;
            }

            ListNode oneStep = head;
            ListNode twoStep = head;
            while (twoStep.next != null && twoStep.next.next != null)
            {
                oneStep = oneStep.next;
                twoStep = twoStep.next.next;
                if (oneStep == twoStep)
                {
                    return true;
                }
            }

            return false;
        }
    }
}