using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 剑指 Offer 57 - II. 和为s的连续正数序列
/// https://leetcode-cn.com/problems/he-wei-sde-lian-xu-zheng-shu-xu-lie-lcof/
public class Offer57_II
{
    public int[][] FindContinuousSequence(int target)
    {
        var ans = new List<List<int>>();
        int left = 1, right = 2;
        var sum = left + right;
        while (left < right)
            if (sum == target)
            {
                var row = new List<int>();
                for (var i = left; i <= right; i++) row.Add(i);
                ans.Add(row);
                sum -= left;
                left++;
            }
            else if (sum < target)
            {
                right++;
                sum += right;
            }
            else
            {
                sum -= left;
                left++;
            }

        var realAns = new int[ans.Count][];
        for (var i = 0; i < ans.Count; i++) realAns[i] = ans[i].ToArray();

        return realAns;
    }
}