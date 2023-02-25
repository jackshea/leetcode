using System.Collections.Generic;

namespace LeetCode.Problems.Hard;

/// 等差数列划分 II - 子序列
/// https://leetcode-cn.com/problems/arithmetic-slices-ii-subsequence/
public class P0446_ArithmeticSlicesIISubsequence
{
    public int NumberOfArithmeticSlices(int[] nums)
    {
        var ans = 0;
        var n = nums.Length;
        var f = new Dictionary<long, int>[n];
        for (var i = 0; i < n; i++) f[i] = new Dictionary<long, int>();

        for (var i = 0; i < n; ++i)
        for (var j = 0; j < i; ++j)
        {
            var d = 1L * nums[i] - nums[j];
            f[j].TryGetValue(d, out var cnt);
            ans += cnt;
            f[i].TryGetValue(d, out var cnti);
            f[i][d] = cnti + cnt + 1;
        }

        return ans;
    }
}