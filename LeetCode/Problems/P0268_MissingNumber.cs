namespace LeetCode.Problems
{
    /// 缺失数字
    /// https://leetcode-cn.com/problems/missing-number/submissions/
    public class P0268_MissingNumber
    {
        public int MissingNumber(int[] nums)
        {
            int expectSum = (1 + nums.Length) * nums.Length / 2;
            int actualSum = 0;
            foreach (var num in nums)
            {
                actualSum += num;
            }

            return expectSum - actualSum;
        }
    }
}