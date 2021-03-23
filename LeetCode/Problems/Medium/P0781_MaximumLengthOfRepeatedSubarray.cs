namespace LeetCode.Problems.Medium
{
    /// 最长重复子数组
    /// https://leetcode-cn.com/problems/maximum-length-of-repeated-subarray/
    public class P0781_MaximumLengthOfRepeatedSubarray
    {
        public int FindLength(int[] A, int[] B)
        {
            int m = A.Length, n = B.Length;
            int[,] dp = new int[m + 1, n + 1];
            int ans = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (A[i - 1] == B[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                        if (ans < dp[i, j])
                        {
                            ans = dp[i, j];
                        }
                    }
                    else
                    {
                        dp[i, j] = 0;
                    }
                }
            }

            return ans;
        }
    }
}