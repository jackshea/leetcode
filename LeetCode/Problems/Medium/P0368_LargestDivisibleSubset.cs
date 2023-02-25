using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 最大整除子集
/// https://leetcode-cn.com/problems/largest-divisible-subset/
public class P0368_LargestDivisibleSubset
{
    public IList<int> LargestDivisibleSubset(int[] nums)
    {
        IList<int> ans = new List<int>();
        if (nums == null || nums.Length == 0) return ans;

        if (nums.Length == 1)
        {
            ans.Add(nums[0]);
            return ans;
        }

        Array.Sort(nums);
        var dp = new List<int>[nums.Length];
        for (var i = 0; i < nums.Length; i++) dp[i] = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var maxSubset = new List<int>();
            for (var j = 0; j < i; j++)
            {
                if (nums[i] % nums[j] != 0) continue;

                if (maxSubset.Count < dp[j].Count) maxSubset = dp[j];
            }

            dp[i].AddRange(maxSubset);
            dp[i].Add(nums[i]);
        }

        foreach (var list in dp)
            if (ans.Count < list.Count)
                ans = list;

        return ans;
    }
}