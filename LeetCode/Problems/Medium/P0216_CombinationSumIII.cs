using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 组合总和 III
/// https://leetcode-cn.com/problems/combination-sum-iii/
public class P0216_CombinationSumIII
{
    private readonly IList<IList<int>> ans = new List<IList<int>>();

    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        Backtrack(new List<int>(), 1, 0, k, n);
        return ans;
    }

    public void Backtrack(IList<int> prefix, int start, int sum, int k, int n)
    {
        if (prefix.Count == k && sum == n)
        {
            ans.Add(new List<int>(prefix));
            return;
        }

        for (var i = start; i < 10; i++)
        {
            prefix.Add(i);
            Backtrack(prefix, i + 1, sum + i, k, n);
            prefix.RemoveAt(prefix.Count - 1);
        }
    }
}