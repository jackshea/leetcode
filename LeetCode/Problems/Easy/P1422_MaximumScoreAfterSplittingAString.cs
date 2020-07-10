using System;

namespace LeetCode.Problems.Easy
{
    /// 分割字符串的最大得分
    /// https://leetcode-cn.com/problems/maximum-score-after-splitting-a-string/
    public class P1422_MaximumScoreAfterSplittingAString
    {
        public int MaxScore(string s)
        {
            int[] left = new int[s.Length];
            int[] right = new int[s.Length];
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0')
                {
                    count++;
                }

                left[i] = count;
            }

            count = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                right[i] = count;
                if (s[i] == '1')
                {
                    count++;
                }
            }

            int ans = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                ans = Math.Max(ans, left[i] + right[i]);
            }

            return ans;
        }
    }
}