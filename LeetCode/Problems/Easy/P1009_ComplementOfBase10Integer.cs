namespace LeetCode.Problems.Easy
{
    /// 十进制整数的反码
    /// https://leetcode-cn.com/problems/complement-of-base-10-integer/
    public class P1009_ComplementOfBase10Integer
    {
        public int BitwiseComplement(int N)
        {
            if (N == 0)
            {
                return 1;
            }

            int ans = 0;
            int b = 1;
            while (N != 0)
            {
                ans += (N % 2 == 0 ? 1 : 0) * b;
                N >>= 1;
                b <<= 1;
            }

            return ans;
        }
    }
}