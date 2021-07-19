using System;

namespace LeetCode.Problems.Hard
{
    /// 最高频元素的频数
    /// https://leetcode-cn.com/problems/frequency-of-the-most-frequent-element/
    public class P1838_FrequencyOfTheMostFrequentElement
    {
        public int MaxFrequency(int[] nums, int k)
        {
            Array.Sort(nums);
            int left = 0, right = 0, ans = 1;
            long kSum = 0;
            while (right < nums.Length - 1)
            {
                right++;
                kSum += (right - left) * (nums[right] - nums[right - 1]);
                while (kSum > k)
                {
                    kSum -= nums[right] - nums[left];
                    left++;
                }

                ans = Math.Max(ans, right - left + 1);
            }

            return ans;
        }
    }
}