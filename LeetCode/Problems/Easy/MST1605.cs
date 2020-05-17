namespace LeetCode.Problems.Easy
{
    /// 阶乘尾数
    /// https://leetcode-cn.com/problems/factorial-zeros-lcci/
    public class MST1605
    {
        public int TrailingZeroes(int n)
        {
            return n == 0 ? 0 : n / 5 + TrailingZeroes(n / 5);
        }
    }
}