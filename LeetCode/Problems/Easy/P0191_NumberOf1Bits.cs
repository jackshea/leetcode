namespace LeetCode.Problems.Easy
{
    /// 位1的个数
    /// https://leetcode-cn.com/problems/number-of-1-bits/
    public class P0191_NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            int ans = 0;
            while (n != 0)
            {
                n &= n - 1;
                ans++;
            }

            return ans;
        }
    }
}