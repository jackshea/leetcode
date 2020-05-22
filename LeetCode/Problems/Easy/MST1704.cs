using System.Linq;

namespace LeetCode.Problems.Easy
{
    /// 消失的数字
    /// https://leetcode-cn.com/problems/missing-number-lcci/
    public class MST1704
    {
        public int MissingNumber(int[] nums)
        {
            var sum = nums.Sum();
            int n = nums.Length;
            int expectSum = (0 + n) * (n + 1) / 2;
            return expectSum - sum;
        }
    }
}