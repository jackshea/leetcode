namespace LeetCode.Problems.Easy
{
    /// 数字的补数
    /// https://leetcode-cn.com/problems/number-complement/
    public class P0476_NumberComplement
    {
        public int FindComplement(int num)
        {
            long max = 2;

            while (num >= max)
            {
                max *= 2;
            }

            return (int)(max - 1 - num);
        }
    }
}