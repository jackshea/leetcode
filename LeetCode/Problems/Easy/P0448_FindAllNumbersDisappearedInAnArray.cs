using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 找到所有数组中消失的数字
/// https://leetcode-cn.com/problems/find-all-numbers-disappeared-in-an-array/
public class P0448_FindAllNumbersDisappearedInAnArray
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        IList<int> result = new List<int>();
        foreach (var num in nums) nums[Math.Abs(num) - 1] = -Math.Abs(nums[Math.Abs(num) - 1]);

        for (var i = 0; i < nums.Length; i++)
            if (nums[i] > 0)
                result.Add(i + 1);

        return result;
    }
}