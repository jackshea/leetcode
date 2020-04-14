using System;

namespace LeetCode.Problems.Medium
{
    /// 比特位计数
    /// https://leetcode-cn.com/problems/counting-bits/
    public class P0338_CountingBits
    {
        public int[] CountBits(int num)
        {
            int[] ans = new int[num + 1];
            for (int i = 1; i <= num; i++)
            {
                ans[i] = ans[i & (i - 1)] + 1;
            }

            return ans;
        }
    }
}