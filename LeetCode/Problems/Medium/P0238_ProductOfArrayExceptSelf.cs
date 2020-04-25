namespace LeetCode.Problems.Medium
{
    /// 除自身以外数组的乘积
    /// https://leetcode-cn.com/problems/product-of-array-except-self/
    public class P0238_ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int length = nums.Length;
            int[] L = new int[length];
            int[] R = new int[length];

            int[] answer = new int[length];
            L[0] = 1;
            for (int i = 1; i < length; i++)
            {
                L[i] = nums[i - 1] * L[i - 1];
            }

            R[length - 1] = 1;
            for (int i = length - 2; i >= 0; i--)
            {
                R[i] = nums[i + 1] * R[i + 1];
            }

            for (int i = 0; i < length; i++)
            {

                answer[i] = L[i] * R[i];
            }

            return answer;
        }
    }
}