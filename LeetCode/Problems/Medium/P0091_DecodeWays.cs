using System;

namespace LeetCode.Problems.Medium
{
    /// 解码方法
    /// https://leetcode-cn.com/problems/decode-ways/
    public class P0091_DecodeWays
    {
        public int NumDecodings(string s)
        {
            int dp0 = 0; // 上一数字不使用时最多解码总数
            int dp1 = 1; // 上一数字被使用时最多解码总数

            if (s[0] == '0')
            {
                return 0;
            }

            for (int i = 1; i < s.Length; i++)
            {
                int newDp0 = dp1;
                int newDp1 = 0;

                if (s[i] != '0')
                {
                    newDp1 += dp1;
                }

                if (s[i - 1] == '2' && s[i] <= '6' || s[i - 1] == '1')
                {
                    newDp1 += Math.Max(dp0, 1);
                }
                else if (s[i] == '0')
                {
                    return 0;
                }

                dp0 = newDp0;
                dp1 = newDp1;
            }

            return dp1;
        }
    }
}