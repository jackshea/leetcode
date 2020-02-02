namespace LeetCode.Problems.Easy
{
    /// 位1的个数
    /// https://leetcode-cn.com/problems/number-of-1-bits/
    public class P0191_NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            int count = 0;
            while (n != 0)
            {
                if (n % 2 == 1)
                {
                    count++;
                }

                n = n >> 1;
            }

            return count;
        }
    }
}