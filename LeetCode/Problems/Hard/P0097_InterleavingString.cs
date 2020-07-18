namespace LeetCode.Problems.Hard
{
    /// 交错字符串
    /// https://leetcode-cn.com/problems/interleaving-string/
    public class P0097_InterleavingString
    {
        public bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }
            bool[,] dp = new bool[s1.Length + 1, s2.Length + 1];
            dp[0, 0] = true;
            for (int i = 0; i < s1.Length; i++)
            {

                if (!dp[i, 0] || s1[i] != s3[i])
                {
                    break;
                }
                dp[i + 1, 0] = true;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (!dp[0, i] || s2[i] != s3[i])
                {
                    break;
                }

                dp[0, i + 1] = true;
            }

            for (int i = 1; i <= s1.Length; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    dp[i, j] = s3[i + j - 1] == s1[i - 1] && dp[i - 1, j] || s3[i + j - 1] == s2[j - 1] && dp[i, j - 1];
                }
            }

            return dp[s1.Length, s2.Length];
        }
    }
}