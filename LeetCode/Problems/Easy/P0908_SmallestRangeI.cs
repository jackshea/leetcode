using System;

namespace LeetCode.Problems.Easy;

/// 最小差值 I
/// https://leetcode-cn.com/problems/smallest-range-i/
public class P0908_SmallestRangeI
{
    public int SmallestRangeI(int[] A, int K)
    {
        var min = A[0];
        var max = A[0];
        foreach (var a in A)
        {
            if (min > a) min = a;

            if (max < a) max = a;
        }

        var diff = max - min - 2 * K;
        return Math.Max(0, diff);
    }
}