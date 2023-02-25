using System;
using System.Linq;

namespace LeetCode.Problems.Medium;

/// 最长数对链
/// https://leetcode-cn.com/problems/maximum-length-of-pair-chain/
public class P0646_MaximumLengthOfPairChain
{
    // DP. O(N^2)
    public int FindLongestChain(int[][] pairs)
    {
        Array.Sort(pairs, (a, b) => a[1].CompareTo(b[1]));
        var n = pairs.Length;
        var dp = new int[n];
        Array.Fill(dp, 1);
        for (var i = 1; i < n; i++)
        for (var j = 0; j < i; j++)
            if (pairs[i][0] > pairs[j][1])
                dp[i] = Math.Max(dp[i], dp[j] + 1);

        return dp.Max();
    }
}

// 贪心.O(NlogN)
public class P0646_MaximumLengthOfPairChain_1
{
    public int FindLongestChain(int[][] pairs)
    {
        Array.Sort(pairs, (a, b) => a[1].CompareTo(b[1]));
        var currMax = int.MinValue;
        var ans = 0;
        foreach (var pair in pairs)
            if (currMax < pair[0])
            {
                ans++;
                currMax = pair[1];
            }

        return ans;
    }
}