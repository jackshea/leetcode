using System;

namespace LeetCode.Problems.Medium
{
    /// 摆动排序 II
    /// https://leetcode-cn.com/problems/wiggle-sort-ii/
    public class P0324_WiggleSortII
    {
        public void WiggleSort(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return;
            }
            Array.Sort(nums, (a, b) => -a.CompareTo(b));
            int[] ans = new int[nums.Length];
            var half = nums.Length / 2;
            int left = 0;
            int right = half;
            for (int i = 0; i < half; i++)
            {
                ans[i * 2] = nums[right++];
                ans[i * 2 + 1] = nums[left++];
            }

            if (ans.Length % 2 != 0)
            {
                ans[ans.Length - 1] = nums[nums.Length - 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = ans[i];
            }
        }
    }
}