using System;

namespace LeetCode.Problems.Medium;

/// 使字符串平衡的最少删除次数
/// https://leetcode.cn/problems/minimum-deletions-to-make-string-balanced/
public class P1653_MinimumDeletionsToMakeStringBalanced
{
    public int MinimumDeletions(string s)
    {
        int countB = 0, ans = 0;
        foreach (var c in s)
        {
            if (c == 'a')
            {
                ans = Math.Min(ans + 1, countB );
            }
            else
            {
                countB++;
            }
        }

        return ans;
    }
}