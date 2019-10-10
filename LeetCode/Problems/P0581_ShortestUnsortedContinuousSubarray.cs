using System;

namespace LeetCode.Problems
{
    /// 最短无序连续子数组
    /// https://leetcode-cn.com/problems/shortest-unsorted-continuous-subarray/
    public class P0581_ShortestUnsortedContinuousSubarray
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            int[] sorted = new int[nums.Length];
            Array.Copy(nums, sorted, nums.Length);
            Array.Sort(sorted);

            int left = 0;
            int right = nums.Length - 1;
            for (left = 0; left < nums.Length; left++)
            {
                if (nums[left] != sorted[left])
                {
                    break;
                }
            }

            for (right = nums.Length - 1; right > left; right--)
            {
                if (nums[right] != sorted[right])
                {
                    break;
                }
            }

            return right - left + 1;
        }
    }
}