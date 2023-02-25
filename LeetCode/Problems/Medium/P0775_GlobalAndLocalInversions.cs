using System;

namespace LeetCode.Problems.Medium;

/// 全局倒置与局部倒置
/// https://leetcode-cn.com/problems/global-and-local-inversions/
public class P0775_GlobalAndLocalInversions
{
    public bool IsIdealPermutation(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
            if (Math.Abs(i - nums[i]) > 1)
                return false;

        return true;
    }
}