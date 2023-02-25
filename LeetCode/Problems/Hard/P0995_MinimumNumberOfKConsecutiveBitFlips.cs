using System.Collections.Generic;

namespace LeetCode.Problems.Hard;

/// K 连续位的最小翻转次数
/// https://leetcode-cn.com/problems/minimum-number-of-k-consecutive-bit-flips/
public class P0995_MinimumNumberOfKConsecutiveBitFlips
{
    public int MinKBitFlips(int[] A, int K)
    {
        var q = new Queue<int>();
        var ans = 0;
        for (var i = 0; i < A.Length; i++)
        {
            if (q.TryPeek(out var top) && i >= top + K) q.Dequeue();
            if (q.Count % 2 == A[i])
            {
                if (i + K > A.Length) return -1;
                q.Enqueue(i);
                ans++;
            }
        }

        return ans;
    }
}