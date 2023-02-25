namespace LeetCode.Problems.Easy;

/// 剑指 Offer 42. 连续子数组的最大和
/// https://leetcode-cn.com/problems/lian-xu-zi-shu-zu-de-zui-da-he-lcof/
public class Offer42
{
    public int MaxSubArray(int[] nums)
    {
        int ans = int.MinValue, sum = 0;
        foreach (var num in nums)
        {
            sum += num;
            if (sum > ans) ans = sum;
            if (sum < 0) sum = 0;
        }

        return ans;
    }
}