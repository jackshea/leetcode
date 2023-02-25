using LeetCode.Common;

namespace LeetCode.Problems.Easy;

/// 返回倒数第 k 个节点
/// https://leetcode-cn.com/problems/kth-node-from-end-of-list-lcci/
public class MST0202
{
    public int KthToLast(ListNode head, int k)
    {
        var len = 0;
        var cur = head;
        while (cur != null)
        {
            len++;
            cur = cur.next;
        }

        cur = head;
        for (var i = 1; i <= len - k; i++) cur = cur.next;

        return cur.val;
    }
}