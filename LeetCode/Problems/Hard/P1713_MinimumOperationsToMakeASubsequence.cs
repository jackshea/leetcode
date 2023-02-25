using System.Collections.Generic;

namespace LeetCode.Problems.Hard;

/// 得到子序列的最少操作次数
/// https://leetcode-cn.com/problems/minimum-operations-to-make-a-subsequence/
public class P1713_MinimumOperationsToMakeASubsequence
{
    public int MinOperations(int[] target, int[] arr)
    {
        var n = target.Length;
        var pos = new Dictionary<int, int>();
        for (var i = 0; i < n; i++) pos[target[i]] = i;
        var d = new List<int>();
        foreach (var v in arr)
            if (pos.TryGetValue(v, out var idx))
            {
                var it = BinarySearch(d, idx);
                if (it != d.Count)
                    d[it] = idx;
                else
                    d.Add(idx);
            }

        return n - d.Count;
    }

    public int BinarySearch(IList<int> d, int target)
    {
        var size = d.Count;
        if (size == 0 || d[size - 1] < target) return size;
        int low = 0, high = size - 1;
        while (low < high)
        {
            var mid = (high - low) / 2 + low;
            if (d[mid] < target)
                low = mid + 1;
            else
                high = mid;
        }

        return low;
    }
}