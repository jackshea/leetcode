using System.Linq;

namespace LeetCode.Problems.Medium;

/// 分割等和子集
/// https://leetcode-cn.com/problems/partition-equal-subset-sum/
public class P0416_PartitionEqualSubsetSum
{
    public bool CanPartition(int[] nums)
    {
        var sum = nums.Sum();
        if (sum % 2 != 0) return false;

        var v = sum / 2;
        var dp = new bool[v + 1]; // 是否存在和为i的组合
        if (nums[0] <= v) dp[nums[0]] = true;

        for (var i = 1; i < nums.Length; i++)
        for (var j = v; j - nums[i] >= 0; j--)
            dp[j] |= dp[j - nums[i]];

        return dp[v];
    }
}