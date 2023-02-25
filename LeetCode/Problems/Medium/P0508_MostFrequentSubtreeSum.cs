using System;
using System.Collections.Generic;
using LeetCode.Common;

namespace LeetCode.Problems.Medium;

/// 出现次数最多的子树元素和
/// https://leetcode-cn.com/problems/most-frequent-subtree-sum/
public class P0508_MostFrequentSubtreeSum
{
    private readonly Dictionary<int, int> freq = new();
    private int maxCnt;

    public int[] FindFrequentTreeSum(TreeNode root)
    {
        if (root == null) return new int[0];
        CalcSumTreeSum(root);
        var ans = new List<int>();
        foreach (var kvp in freq)
            if (kvp.Value == maxCnt)
                ans.Add(kvp.Key);

        return ans.ToArray();
    }

    private int CalcSumTreeSum(TreeNode root)
    {
        if (root == null) return 0;

        var sum = root.val + CalcSumTreeSum(root.left) + CalcSumTreeSum(root.right);
        freq.TryGetValue(sum, out var cnt);
        freq[sum] = cnt + 1;
        maxCnt = Math.Max(maxCnt, freq[sum]);
        return sum;
    }
}