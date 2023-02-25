using System;

namespace LeetCode.Problems.Medium;

/// 下一个排列
/// https://leetcode-cn.com/problems/next-permutation/
public class P0031_NextPermutation
{
    public void NextPermutation(int[] nums)
    {
        if (nums.Length <= 1) return;

        var i = nums.Length - 1;
        while (i > 0 && nums[i - 1] >= nums[i]) i--;

        if (i > 0)
        {
            var j = i + 1;
            while (j < nums.Length && nums[i - 1] < nums[j]) j++;

            j--;
            var temp = nums[i - 1];
            nums[i - 1] = nums[j];
            nums[j] = temp;
        }

        Array.Reverse(nums, i, nums.Length - i);
    }
}