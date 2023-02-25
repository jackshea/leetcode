using System;

namespace LeetCode.Problems.Medium.Tests;

/// 使序列递增的最小交换次数
/// https://leetcode-cn.com/problems/minimum-swaps-to-make-sequences-increasing/
public class P0801_MinimumSwapsToMakeSequencesIncreasing
{
    public int MinSwap(int[] A, int[] B)
    {
        int n1 = 0, s1 = 1;
        for (var i = 1; i < A.Length; i++)
        {
            var n2 = int.MaxValue;
            var s2 = int.MaxValue;
            if (A[i - 1] < A[i] && B[i - 1] < B[i])
            {
                n2 = n1;
                s2 = s1 + 1;
            }

            if (A[i - 1] < B[i] && B[i - 1] < A[i])
            {
                n2 = Math.Min(n2, s1);
                s2 = Math.Min(s2, n1 + 1);
            }

            n1 = n2;
            s1 = s2;
        }

        return Math.Min(n1, s1);
    }
}