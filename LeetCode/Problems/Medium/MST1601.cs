namespace LeetCode.Problems.Medium
{
    /// 交换数字
    /// https://leetcode-cn.com/problems/swap-numbers-lcci/
    public class MST1601
    {
        public int[] SwapNumbers(int[] numbers)
        {
            numbers[0] ^= numbers[1];
            numbers[1] ^= numbers[0];
            numbers[0] ^= numbers[1];
            return numbers;
        }
    }
}