using System;

namespace LeetCode.Problems.Easy;

/// 使数组中所有元素都等于零
/// https://leetcode.cn/problems/make-array-zero-by-subtracting-equal-amounts/
public class P2357_MakeArrayZeroBySubtractingEqualAmounts
{
    public int MinimumOperations(int[] nums)
    {
        Array.Sort(nums);
        var max = 0;
        var ans = 0;
        foreach (var num in nums)
            if (num > max)
            {
                max = num;
                ans++;
            }

        return ans;
    }
}