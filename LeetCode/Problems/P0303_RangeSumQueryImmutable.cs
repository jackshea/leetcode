namespace LeetCode.Problems
{
    /// 区域和检索 - 数组不可变
    /// https://leetcode-cn.com/problems/range-sum-query-immutable/
    public class NumArray
    {
        private int[] sumArray = null;

        public NumArray(int[] nums)
        {
            sumArray = new int[nums.Length];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                sumArray[i] = sum;
            }
        }

        public int SumRange(int i, int j)
        {
            return i > 0 ? sumArray[j] - sumArray[i - 1] : sumArray[j];
        }
    }
}