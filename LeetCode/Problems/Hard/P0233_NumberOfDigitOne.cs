using System;

namespace LeetCode.Problems.Hard
{
    /// 枚举每一数位上 11 的个数
    /// https://leetcode-cn.com/problems/number-of-digit-one/
    public class P0233_NumberOfDigitOne
    {
        public int CountDigitOne(int n)
        {
            long mulk = 1;
            int ans = 0;
            for (int k = 0; n >= mulk; ++k)
            {
                ans += (int)(n / (mulk * 10) * mulk) + (int)Math.Min(Math.Max(n % (mulk * 10) - mulk + 1, 0), mulk);
                mulk *= 10;
            }
            return ans;
        }
    }
}