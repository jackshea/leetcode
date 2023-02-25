using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 分隔链表
/// https://leetcode-cn.com/problems/split-linked-list-in-parts/
public class P0725_SplitLinkedListInParts
{
    public ListNode[] SplitListToParts(ListNode root, int k)
    {
        var cur = root;
        var len = 0;
        while (cur != null)
        {
            len++;
            cur = cur.next;
        }

        var subLen = len / k;
        var remain = len % k;
        var ans = new ListNode[k];
        cur = root;
        var head = new ListNode(-1);
        for (var i = 0; i < k; i++)
        {
            head.next = null;
            var subCur = head;
            var extra = i < remain ? 1 : 0;
            for (var j = 0; j < subLen + extra; j++)
            {
                subCur.next = cur;
                cur = cur.next;
                subCur = subCur.next;
                if (j == subLen + extra - 1) subCur.next = null;
            }

            ans[i] = head.next;
        }

        return ans;
    }
}