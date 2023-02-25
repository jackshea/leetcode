using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 全排列 II
/// https://leetcode-cn.com/problems/permutations-ii/
public class P0047_PermutationsII
{
    private readonly IList<IList<int>> ans = new List<IList<int>>();

    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        Array.Sort(nums);
        DFS(nums, 0);
        return ans;
    }

    private void DFS(int[] nums, int i)
    {
        if (i >= nums.Length - 1)
        {
            ans.Add(new List<int>(nums));
            return;
        }

        for (var j = i; j < nums.Length; j++)
        {
            if (!CanSwap(nums, i, j)) continue;

            Swap(nums, i, j);
            DFS(nums, i + 1);
            Swap(nums, i, j);
        }
    }

    private void Swap(int[] nums, int i, int j)
    {
        var temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    /// 为了去重，可以交换的条件是mums[begin...end-1]没有出现过等于nums[end]的元素。
    private bool CanSwap(int[] nums, int begin, int end)
    {
        for (var k = begin; k < end; k++)
            if (nums[k] == nums[end])
                return false;

        return true;
    }
}