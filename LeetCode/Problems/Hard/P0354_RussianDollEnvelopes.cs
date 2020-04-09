using System;

namespace LeetCode.Problems.Hard
{
    /// 俄罗斯套娃信封问题
    /// https://leetcode-cn.com/problems/russian-doll-envelopes/
    /// 排序后算法同 最长上升子序列
    public class P0354_RussianDollEnvelopes
    {
        public int MaxEnvelopes(int[][] envelopes)
        {
            if (envelopes.Length == 0)
            {
                return 0;
            }

            // 按主宽度后高度排序
            Array.Sort(envelopes, (a, b) =>
            {
                var compareToW = a[0].CompareTo(b[0]);
                if (compareToW == 0)
                {
                    return a[1].CompareTo(b[1]);
                }

                return compareToW;
            });

            // 类似最长上升子序列
            int[] dp = new int[envelopes.Length];
            dp[0] = 1;
            int ans = 1;
            for (int i = 1; i < envelopes.Length; i++)
            {
                var e = envelopes[i];
                int max = 0;
                for (int j = 0; j < i; j++)
                {
                    if (e[0] > envelopes[j][0] && e[1] > envelopes[j][1] && max < dp[j])
                    {
                        max = dp[j];
                    }
                }

                dp[i] = max + 1;
                if (ans < dp[i])
                {
                    ans = dp[i];
                }
            }

            return ans;
        }
    }
}