using System.Collections.Generic;

namespace LeetCode.Problems.Hard
{
    /// K 连续位的最小翻转次数
    /// https://leetcode-cn.com/problems/minimum-number-of-k-consecutive-bit-flips/
    public class P0995_MinimumNumberOfKConsecutiveBitFlips
    {
        public int MinKBitFlips(int[] A, int K)
        {
            Queue<int> q = new Queue<int>();
            int ans = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (q.TryPeek(out var top) && i >= top + K)
                {
                    q.Dequeue();
                }
                if (q.Count % 2 == A[i])
                {
                    if (i + K > A.Length)
                    {
                        return -1;
                    }
                    q.Enqueue(i);
                    ans++;
                }
            }

            return ans;
        }
    }
}