using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 四数相加 II
/// https://leetcode-cn.com/problems/4sum-ii/
public class P0454_4SumII
{
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
    {
        var abSum = new Dictionary<int, int>();
        for (var i = 0; i < A.Length; i++)
        for (var j = 0; j < B.Length; j++)
        {
            var key = A[i] + B[j];
            abSum.TryGetValue(key, out var cnt);
            abSum[key] = cnt + 1;
        }

        var ans = 0;
        for (var i = 0; i < C.Length; i++)
        for (var j = 0; j < D.Length; j++)
        {
            var key = C[i] + D[j];
            abSum.TryGetValue(-key, out var cnt);
            ans += cnt;
        }

        return ans;
    }
}