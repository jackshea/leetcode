namespace LeetCode.Problems.Easy
{
    /// 最大子序和
    /// https://leetcode-cn.com/problems/maximum-subarray/description/
    public class P0053_MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int sum = nums[0];
            int current = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (current < 0)
                {
                    current = nums[i];
                }
                else
                {
                    current += nums[i];
                }

                if (current > sum)
                {
                    sum = current;
                }
            }

            return sum;
        }
    }
}