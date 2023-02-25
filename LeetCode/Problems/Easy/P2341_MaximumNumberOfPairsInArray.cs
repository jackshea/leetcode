using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 数组能形成多少数对
/// https://leetcode.cn/problems/maximum-number-of-pairs-in-array/
public class P2341_MaximumNumberOfPairsInArray
{
    public int[] NumberOfPairs(int[] nums)
    {
        var dic = new Dictionary<int, int>();
        foreach (var num in nums)
            if (dic.TryGetValue(num, out var count))
                dic[num] = count + 1;
            else
                dic[num] = 1;

        var ans = 0;
        foreach (var kvp in dic) ans += kvp.Value / 2;

        return new[] { ans, nums.Length - ans * 2 };
    }
}