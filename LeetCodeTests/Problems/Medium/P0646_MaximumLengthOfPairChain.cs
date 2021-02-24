using System;

namespace LeetCode.Problems.Medium.Tests
{
    /// 最长数对链
    /// https://leetcode-cn.com/problems/maximum-length-of-pair-chain/
    public class P0646_MaximumLengthOfPairChain
    {
        public int FindLongestChain(int[][] pairs)
        {
            Array.Sort(pairs, (a, b) => a[1].CompareTo(b[1]));
            var n = pairs.Length;
            int[] dp = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                int idx = i - 1;
                while (idx >= 0 && pairs[idx][1] >= pairs[i][0])
                {
                    idx--;
                }

                dp[i + 1] = Math.Max(dp[i], idx < 0 ? 1 : dp[idx + 1] + 1);
            }

            return dp[n];
        }
    }
}