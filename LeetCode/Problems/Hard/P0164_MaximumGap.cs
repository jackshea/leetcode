using System;

namespace LeetCode.Problems.Hard
{
    /// 最大间距
    /// https://leetcode-cn.com/problems/maximum-gap/
    public class P0164_MaximumGap
    {
        public int MaximumGap(int[] nums)
        {
            Array.Sort(nums);
            int ans = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                ans = Math.Max(ans, nums[i] - nums[i - 1]);
            }

            return ans;
        }
    }
}