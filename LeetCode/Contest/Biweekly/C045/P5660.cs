using System;

namespace LeetCode.Contest.Biweekly.C045;

/// 最多可以参加的会议数目 II
/// https://leetcode-cn.com/problems/maximum-number-of-events-that-can-be-attended-ii/
public class P5660
{
    public int MaxValue(int[][] events, int k)
    {
        Array.Sort(events, (a, b) => a[1].CompareTo(b[1]));
        var dp = new int[events.Length][];
        for (var i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[k + 1];
            Array.Fill(dp[i], int.MinValue);
        }

        dp[0][0] = 0;
        dp[0][1] = events[0][2];
        for (var i = 1; i < events.Length; i++)
        {
            // 参加会议i
            int left = 0, right = i;
            while (right - left > 1)
            {
                var mid = (left + right) / 2;
                if (events[mid][1] >= events[i][0])
                    right = mid;
                else
                    left = mid;
            }

            if (events[left][1] >= events[i][0])
                dp[i][1] = Math.Max(dp[i][1], events[i][2]);
            else
                for (var j = 1; j <= k; j++)
                    dp[i][j] = Math.Max(dp[i][j], dp[left][j - 1] + events[i][2]);

            // 不参加会议i
            for (var j = 0; j <= k; j++) dp[i][j] = Math.Max(dp[i][j], dp[i - 1][j]);
        }

        var ans = 0;
        for (var i = 0; i <= k; i++) ans = Math.Max(ans, dp[events.Length - 1][i]);

        return ans;
    }
}