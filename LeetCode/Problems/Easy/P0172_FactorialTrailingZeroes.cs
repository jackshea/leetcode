namespace LeetCode.Problems.Easy;

/// 阶乘后的零
/// https://leetcode-cn.com/problems/factorial-trailing-zeroes/description/
public class P0172_FactorialTrailingZeroes
{
    public int TrailingZeroes(int n)
    {
        return n == 0 ? 0 : n / 5 + TrailingZeroes(n / 5);
    }
}