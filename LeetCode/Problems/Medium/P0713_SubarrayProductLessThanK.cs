namespace LeetCode.Problems.Medium;

/// 乘积小于K的子数组
/// https://leetcode-cn.com/problems/subarray-product-less-than-k/
public class P0713_SubarrayProductLessThanK
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        if (k == 0) return 0;

        int left = 0, right = 0, ans = 0, product = 1;
        while (right < nums.Length)
        {
            product *= nums[right++];

            while (product >= k && left < right) product /= nums[left++];

            ans += right - left;
        }

        return ans;
    }
}