namespace LeetCode.Problems.Easy;

/// 最少操作使数组递增
/// https://leetcode-cn.com/problems/minimum-operations-to-make-the-array-increasing/
public class P1827_MinimumOperationsToMakeTheArrayIncreasing
{
    public int MinOperations(int[] nums)
    {
        var ans = 0;
        var max = nums[0];
        for (var i = 1; i < nums.Length; i++)
            if (nums[i] > max)
            {
                max = nums[i];
            }
            else
            {
                max++;
                ans += max - nums[i];
            }

        return ans;
    }
}