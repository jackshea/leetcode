namespace LeetCode.Problems.Easy
{
    /// 一维数组的动态和
    /// https://leetcode-cn.com/problems/running-sum-of-1d-array/
    public class P1480_RunningSumOf1dArray
    {
        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}