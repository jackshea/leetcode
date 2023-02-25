using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 子集 II
/// https://leetcode-cn.com/problems/subsets-ii/
public class P0090_SubsetsII
{
    private readonly IList<IList<int>> ans = new List<IList<int>>();
    private int[] nums;

    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        this.nums = nums;
        Array.Sort(nums);
        ans.Add(new List<int>());
        DFS(0, new List<int>());
        return ans;
    }

    private void DFS(int start, List<int> selected)
    {
        if (start == nums.Length) return;

        for (var i = start; i < nums.Length; i++)
            if (i == start || nums[i] != nums[i - 1])
            {
                selected.Add(nums[i]);
                ans.Add(new List<int>(selected));
                DFS(i + 1, selected);
                selected.RemoveAt(selected.Count - 1);
            }
    }
}