using System;

namespace LeetCode.Problems.Easy;

/// 数组拆分 I
/// https://leetcode-cn.com/problems/array-partition-i/
public class P0561_ArrayPartitionI
{
    public int ArrayPairSum(int[] nums)
    {
        Array.Sort(nums);
        var result = 0;
        for (var i = 0; i < nums.Length; i += 2) result += nums[i];

        return result;
    }
}