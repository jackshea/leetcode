using System;

namespace LeetCode.Problems.Easy
{
    /// 最富有客户的资产总量
    /// https://leetcode-cn.com/problems/richest-customer-wealth/
    public class P1672_RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            int ans = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < accounts[0].Length; j++)
                {
                    sum += accounts[i][j];
                }

                ans = Math.Max(ans, sum);
            }

            return ans;
        }
    }
}