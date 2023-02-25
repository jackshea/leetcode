using System;

namespace LeetCode.Problems.Easy;

/// 分发饼干
/// https://leetcode-cn.com/problems/assign-cookies/
public class P0455_AssignCookies
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        var gIndex = 0;
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (gIndex >= g.Length) break;

            if (g[gIndex] <= s[i])
            {
                result++;
                gIndex++;
            }
        }

        return result;
    }
}