namespace LeetCode.Problems.Medium
{
    /// 等差数列划分
    /// https://leetcode-cn.com/problems/arithmetic-slices/
    public class P0413_ArithmeticSlices
    {
        public int NumberOfArithmeticSlices(int[] A)
        {
            int ans = 0;
            int dp = 0;
            for (int i = 2; i < A.Length; i++)
            {
                if (A[i] - A[i - 1] == A[i - 1] - A[i - 2])
                {
                    dp++;
                    ans += dp;
                }
                else
                {
                    dp = 0;
                }
            }

            return ans;
        }
    }
}