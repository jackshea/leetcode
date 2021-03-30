using System;
using System.Linq;

namespace LeetCode.Problems.Medium
{
    /// 删除与获得点数
    /// https://leetcode-cn.com/problems/delete-and-earn/
    public class P0740_DeleteAndEarn
    {
        public int DeleteAndEarn(int[] nums)
        {
            int max = nums.Max();
            int[] points = new int[max + 1];
            foreach (var num in nums)
            {
                points[num] += num;
            }

            int dp0 = 0;// 前一个没选的最大值
            int dp1 = points[0];// 前一个选了的最大值

            for (int i = 1; i < points.Length; i++)
            {
                int newDp0 = Math.Max(dp0, dp1);
                dp1 = dp0 + points[i];
                dp0 = newDp0;
            }

            return Math.Max(dp0, dp1);
        }
    }
}