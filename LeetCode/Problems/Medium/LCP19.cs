using System;

namespace LeetCode.Problems.Medium;

/// LCP 19. 秋叶收藏集
/// https://leetcode-cn.com/problems/UlBDOe/
public class LCP19
{
    public int MinimumOperations(string leaves)
    {
        var a = leaves[0] == 'y' ? 1 : 0;
        var b = leaves.Length;
        var c = b;
        for (var i = 1; i < leaves.Length; i++)
        {
            var leaf = leaves[i];
            var isRed = leaf == 'r' ? 1 : 0;
            var isYellow = leaf == 'y' ? 1 : 0;
            if (i > 2) c = Math.Min(b, c) + isYellow;
            b = Math.Min(a, b) + isRed;
            a = a + isYellow;
        }

        return c;
    }
}