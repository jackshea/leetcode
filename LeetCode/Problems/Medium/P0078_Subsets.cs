using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 子集
/// https://leetcode-cn.com/problems/subsets/
public class P0078_Subsets
{
    private IList<IList<int>> ans;
    private int[] nums;

    public IList<IList<int>> Subsets(int[] nums)
    {
        this.nums = nums;
        ans = new List<IList<int>>();
        ans.Add(new List<int>());
        DFS(0, new List<int>());
        return ans;
    }

    private void DFS(int start, List<int> selected)
    {
        if (start == nums.Length) return;

        for (var i = start; i < nums.Length; i++)
        {
            selected.Add(nums[i]);
            ans.Add(new List<int>(selected));
            DFS(i + 1, selected);
            selected.RemoveAt(selected.Count - 1);
        }
    }
}