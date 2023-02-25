namespace LeetCode.Problems.Easy;

/// 最大子序和
/// https://leetcode-cn.com/problems/maximum-subarray/description/
public class P0053_MaximumSubarray
{
    public int MaxSubArray(int[] nums)
    {
        var sum = nums[0];
        var current = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            if (current < 0)
                current = nums[i];
            else
                current += nums[i];

            if (current > sum) sum = current;
        }

        return sum;
    }
}