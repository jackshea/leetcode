using System;

namespace LeetCode.Problems.Medium.P0398;

/// 随机数索引
/// https://leetcode-cn.com/problems/random-pick-index/
public class Solution
{
    private readonly int[] nums;

    public Solution(int[] nums)
    {
        this.nums = nums;
    }

    public int Pick(int target)
    {
        var count = 0;
        var ans = 0;
        var random = new Random();
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] == target)
            {
                count++;
                if (random.Next(count) == 0) ans = i;
            }

        return ans;
    }
}