using System;

namespace LeetCode.Problems.Easy;

/// 范围求和 II
/// https://leetcode-cn.com/problems/range-addition-ii/
public class P0598_RangeAdditionII
{
    public int MaxCount(int m, int n, int[][] ops)
    {
        var a = m;
        var b = n;
        foreach (var op in ops)
        {
            a = Math.Min(a, op[0]);
            b = Math.Min(b, op[1]);
        }

        return a * b;
    }
}