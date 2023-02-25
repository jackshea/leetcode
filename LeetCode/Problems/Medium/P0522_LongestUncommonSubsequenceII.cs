using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 最长特殊序列 II
/// https://leetcode-cn.com/problems/longest-uncommon-subsequence-ii/
public class P0522_LongestUncommonSubsequenceII
{
    public int FindLUSlength(string[] strs)
    {
        Array.Sort(strs, (a, b) =>
        {
            var c = -a.Length.CompareTo(b.Length);
            if (c == 0) return a.CompareTo(b);

            return c;
        });

        if (strs[0] != strs[1]) return strs[0].Length;

        var repeat = new HashSet<string>();
        for (var i = 1; i < strs.Length; i++)
            if (strs[i - 1] == strs[i])
                repeat.Add(strs[i]);
        ;
        for (var i = 1; i < strs.Length; i++)
        {
            if (repeat.Contains(strs[i])) continue;

            var check = false;
            for (var j = i - 1; j >= 0; j--)
                if (IsSubsequence(strs[i], strs[j]))
                {
                    check = true;
                    break;
                }

            if (!check) return strs[i].Length;
        }

        return -1;
    }

    private bool IsSubsequence(string sub, string target)
    {
        var subI = 0;
        for (var i = 0; i < target.Length; i++)
        {
            if (subI >= sub.Length) return true;

            if (target[i] == sub[subI]) subI++;
        }

        return subI >= sub.Length;
    }
}