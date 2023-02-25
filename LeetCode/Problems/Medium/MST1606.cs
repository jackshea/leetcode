using System;

namespace LeetCode.Problems.Medium;

/// 最小差
/// https://leetcode-cn.com/problems/smallest-difference-lcci/
public class MST1606
{
    public int SmallestDifference(int[] a, int[] b)
    {
        Array.Sort(a);
        Array.Sort(b);
        int ai = 0, bi = 0;
        var ans = long.MaxValue;
        while (ai < a.Length && bi < b.Length)
        {
            ans = Math.Min(ans, Math.Abs(a[ai] - (long)b[bi]));
            if (ans == 0) return 0;
            if (a[ai] < b[bi])
                ai++;
            else
                bi++;
        }

        return (int)ans;
    }
}