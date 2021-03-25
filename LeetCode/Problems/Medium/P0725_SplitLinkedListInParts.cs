using LeetCode.Common;

namespace LeetCode.Problems.Medium
{
    /// 分隔链表
    /// https://leetcode-cn.com/problems/split-linked-list-in-parts/
    public class P0725_SplitLinkedListInParts
    {
        public ListNode[] SplitListToParts(ListNode root, int k)
        {
            ListNode cur = root;
            int len = 0;
            while (cur != null)
            {
                len++;
                cur = cur.next;
            }

            int subLen = len / k;
            int remain = len % k;
            ListNode[] ans = new ListNode[k];
            cur = root;
            ListNode head = new ListNode(-1);
            for (int i = 0; i < k; i++)
            {
                head.next = null;
                ListNode subCur = head;
                int extra = i < remain ? 1 : 0;
                for (int j = 0; j < subLen + extra; j++)
                {
                    subCur.next = cur;
                    cur = cur.next;
                    subCur = subCur.next;
                    if (j == subLen + extra - 1)
                    {
                        subCur.next = null;
                    }
                }

                ans[i] = head.next;
            }

            return ans;
        }
    }
}