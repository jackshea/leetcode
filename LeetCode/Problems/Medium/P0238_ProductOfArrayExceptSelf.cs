namespace LeetCode.Problems.Medium;

/// 除自身以外数组的乘积
/// https://leetcode-cn.com/problems/product-of-array-except-self/
public class P0238_ProductOfArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var length = nums.Length;
        var L = new int[length];
        var R = new int[length];

        var answer = new int[length];
        L[0] = 1;
        for (var i = 1; i < length; i++) L[i] = nums[i - 1] * L[i - 1];

        R[length - 1] = 1;
        for (var i = length - 2; i >= 0; i--) R[i] = nums[i + 1] * R[i + 1];

        for (var i = 0; i < length; i++) answer[i] = L[i] * R[i];

        return answer;
    }
}