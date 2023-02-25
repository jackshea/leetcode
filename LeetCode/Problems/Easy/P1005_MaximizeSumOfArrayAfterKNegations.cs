using System;
using System.Linq;

namespace LeetCode.Problems.Easy;

/// K 次取反后最大化的数组和
/// https://leetcode-cn.com/problems/maximize-sum-of-array-after-k-negations/
public class P1005_MaximizeSumOfArrayAfterKNegations
{
    public int LargestSumAfterKNegations(int[] A, int K)
    {
        Array.Sort(A);
        var minIndex = 0;
        for (var i = 0; i < K; i++)
        {
            A[minIndex] = -A[minIndex];
            if (minIndex < A.Length - 1 && A[minIndex] > A[minIndex + 1]) minIndex++;
        }

        return A.Sum();
    }
}