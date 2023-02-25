using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 和为K的子数组
/// https://leetcode-cn.com/problems/subarray-sum-equals-k/
public class P0560_SubarraySumEqualsK
{
    public int SubarraySum(int[] nums, int k)
    {
        var dic = new Dictionary<int, int>();
        dic.Add(0, 1);
        int sum = 0, ans = 0;
        foreach (var num in nums)
        {
            sum += num;

            if (dic.TryGetValue(sum - k, out var sumk)) ans += sumk;

            var pre = 0;
            dic.TryGetValue(sum, out pre);
            dic[sum] = 1 + pre;
        }

        return ans;
    }
}