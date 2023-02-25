namespace LeetCode.Problems.Medium;

/// 划分为k个相等的子集
/// https://leetcode-cn.com/problems/partition-to-k-equal-sum-subsets/
public class P0698_PartitionToKEqualSumSubsets
{
    public bool CanPartitionKSubsets(int[] nums, int k)
    {
        int sum = 0, max = 0;
        var n = nums.Length;
        for (var i = 0; i < n; i++)
        {
            sum += nums[i];
            if (nums[i] > max) max = nums[i];
        }

        var avg = sum / k;
        if (avg * k != sum || max > avg) return false;
        var used = new bool[n];
        return BackTracking(nums, k, avg, 0, 0, used);
    }

    private bool BackTracking(int[] nums, int k, int target, int cur, int start, bool[] used)
    {
        if (k == 0) return true;
        if (cur == target) return BackTracking(nums, k - 1, target, 0, 0, used);
        for (var i = start; i < nums.Length; i++)
            if (!used[i] && cur + nums[i] <= target)
            {
                used[i] = true;
                if (BackTracking(nums, k, target, cur + nums[i], i + 1, used)) return true;
                used[i] = false;
            }

        return false;
    }
}