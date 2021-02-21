using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Medium
{
    /// 绝对差不超过限制的最长连续子数组
    /// https://leetcode-cn.com/problems/longest-continuous-subarray-with-absolute-diff-less-than-or-equal-to-limit/
    public class P1438_LongestContinuousSubarrayWithAbsoluteDiffLessThanOrEqualToLimit
    {
        public int LongestSubarray(int[] nums, int limit)
        {
            int left = 0, right = 0;
            int ans = 0;
            SortedList<int, int> sorted = new SortedList<int, int>();
            while (right < nums.Length)
            {
                if (sorted.Keys.Count < 2 || sorted.Keys.Count > 0 && sorted.Keys[sorted.Count - 1] - sorted.Keys[0] <= limit)
                {
                    sorted.TryGetValue(nums[right], out var count);
                    sorted[nums[right++]] = count + 1;
                }

                while (sorted.Keys.Count > 0 && sorted.Keys[sorted.Count - 1] - sorted.Keys[0] > limit)
                {
                    var leftNum = nums[left];
                    sorted[leftNum] = sorted[leftNum] - 1;
                    if (sorted[leftNum] == 0)
                    {
                        sorted.Remove(leftNum);
                    }

                    left++;
                }

                ans = Math.Max(ans, right - left + 1);
            }

            return ans;
        }
    }
}