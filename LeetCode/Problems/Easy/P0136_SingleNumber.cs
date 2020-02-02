namespace LeetCode.Problems.Easy
{
    /// 只出现一次的数字
    /// https://leetcode-cn.com/problems/single-number/description/
    public class P0136_SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;
            foreach (var num in nums)
            {
                result ^= num;
            }

            return result;
        }
    }
}