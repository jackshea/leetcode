using System;

namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 59 - I. 滑动窗口的最大值
    /// https://leetcode-cn.com/problems/hua-dong-chuang-kou-de-zui-da-zhi-lcof/
    public class Offer59_I
    {
        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
            {
                return new int[0];
            }
            int max = nums[0];
            for (int i = 0; i < k; i++)
            {
                max = Math.Max(max, nums[i]);
            }
            int[] ans = new int[nums.Length - k + 1];
            ans[0] = max;
            for (int i = 0; i < nums.Length - k; i++)
            {
                int willOut = nums[i];
                int willIn = nums[i + k];
                if (willIn >= willOut)
                {
                    max = Math.Max(max, willIn);
                }
                else if (willOut >= max)
                {
                    max = willIn;
                    for (int j = i + 1; j < i + k; j++)
                    {
                        max = Math.Max(max, nums[j]);
                    }
                }

                ans[i + 1] = max;
            }

            return ans;
        }
    }
}