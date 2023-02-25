using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 链表组件
/// https://leetcode-cn.com/problems/linked-list-components/
public class P0817_LinkedListComponents
{
    public int NumComponents(ListNode head, int[] nums)
    {
        var g = new HashSet<int>();
        foreach (var num in nums) g.Add(num);

        var ans = 0;
        var isLast = false; // 最后一结点值是否在列表G中
        var curr = head;

        while (curr != null)
        {
            if (g.Contains(curr.val))
            {
                isLast = true;
            }
            else
            {
                if (isLast) ans++;

                isLast = false;
            }

            curr = curr.next;
        }

        ans += isLast ? 1 : 0;
        return ans;
    }
}