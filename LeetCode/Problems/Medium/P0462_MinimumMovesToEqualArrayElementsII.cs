using System;

namespace LeetCode.Problems.Medium;

/// 最少移动次数使数组元素相等 II
/// https://leetcode-cn.com/problems/minimum-moves-to-equal-array-elements-ii/
public class P0462_MinimumMovesToEqualArrayElementsII
{
    public int MinMoves2(int[] nums)
    {
        Array.Sort(nums);
        var mid = nums[nums.Length / 2];
        var ans = 0;
        foreach (var num in nums) ans += Math.Abs(num - mid);

        return ans;
    }
}