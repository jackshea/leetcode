using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 剑指 Offer 22. 链表中倒数第k个节点
/// https://leetcode-cn.com/problems/lian-biao-zhong-dao-shu-di-kge-jie-dian-lcof/
public class Offer22
{
    public ListNode GetKthFromEnd(ListNode head, int k)
    {
        var ln1 = head;
        var ln2 = head;
        var n = 0;
        while (ln1 != null)
        {
            ln1 = ln1.next;
            n++;
            if (n > k) ln2 = ln2.next;
        }

        return ln2;
    }
}