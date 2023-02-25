using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 丑数 II
/// https://leetcode-cn.com/problems/ugly-number-ii/
public class P0264_UglyNumberII
{
    public int NthUglyNumber(int n)
    {
        var uglyNums = new List<int>();
        uglyNums.Add(1);
        int n2 = 0, n3 = 0, n5 = 0;
        while (uglyNums.Count < n)
        {
            var nextUglyNums = Math.Min(Math.Min(uglyNums[n2] * 2, uglyNums[n3] * 3), uglyNums[n5] * 5);
            uglyNums.Add(nextUglyNums);
            if (nextUglyNums == uglyNums[n2] * 2) n2++;
            if (nextUglyNums == uglyNums[n3] * 3) n3++;
            if (nextUglyNums == uglyNums[n5] * 5) n5++;
        }

        return uglyNums[n - 1];
    }
}