using System;

namespace LeetCode.Problems.Medium
{
    /// 两个字符串的删除操作
    /// https://leetcode-cn.com/problems/delete-operation-for-two-strings/
    public class P0583_DeleteOperationForTwoStrings
    {
        public int MinDistance(string word1, string word2)
        {
            return word1.Length + word2.Length - 2 * lcs(word1, word2);
        }

        private int lcs(string word1, string word2)
        {
            int[,] dp = new int[word1.Length + 1, word2.Length + 1];
            for (int i = 1; i <= word1.Length; i++)
            {
                for (int j = 1; j <= word2.Length; j++)
                {
                    if (word1[i - 1] == word2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                    }
                }
            }

            return dp[word1.Length, word2.Length];
        }
    }
}