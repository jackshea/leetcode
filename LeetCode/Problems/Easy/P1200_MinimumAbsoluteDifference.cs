using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 最小绝对差
/// https://leetcode-cn.com/problems/minimum-absolute-difference/
public class P1200_MinimumAbsoluteDifference
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        Array.Sort(arr);
        var minDiff = int.MaxValue;
        for (var i = 0; i < arr.Length - 1; i++)
        {
            var diff = arr[i + 1] - arr[i];
            if (diff < minDiff) minDiff = diff;
        }

        IList<IList<int>> ans = new List<IList<int>>();
        for (var i = 0; i < arr.Length - 1; i++)
        {
            var diff = arr[i + 1] - arr[i];
            if (diff == minDiff) ans.Add(new List<int> { arr[i], arr[i + 1] });
        }

        return ans;
    }
}