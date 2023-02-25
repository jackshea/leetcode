using System;

namespace LeetCode.Problems.Medium;

/// 最接近的三数之和
/// https://leetcode-cn.com/problems/3sum-closest/
public class P0016_3SumClosest
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        var minDiff = int.MaxValue;
        var ans = 0;
        Array.Sort(nums);
        for (var i = 0; i < nums.Length; i++)
        {
            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];
                if (sum > target)
                    right--;
                else if (sum < target)
                    left++;
                else
                    return sum;

                var diff = Math.Abs(sum - target);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    ans = sum;
                }
            }
        }

        return ans;
    }
}