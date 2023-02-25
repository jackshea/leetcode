namespace LeetCode.Problems.Easy;

/// 只出现一次的数字 II
/// https://leetcode-cn.com/problems/single-number-ii/description/
/// https://leetcode.com/problems/single-number-ii/discuss/43294/Challenge-me-thx
public class P0137_SingleNumberII
{
    public int SingleNumber(int[] nums)
    {
        int ones = 0, twos = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            ones = (ones ^ nums[i]) & ~twos;
            twos = (twos ^ nums[i]) & ~ones;
        }

        return ones;
    }
}