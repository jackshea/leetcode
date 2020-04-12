using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 单词拆分
    /// https://leetcode-cn.com/problems/word-break/
    public class P0139_WordBreak
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            HashSet<string> set = new HashSet<string>();
            foreach (var word in wordDict)
            {
                set.Add(word);
            }

            bool[] dp = new bool[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    bool isContains = set.Contains(s.Substring(j, i - j + 1));
                    if (isContains && (j == 0 || j > 0 && dp[j - 1]))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            return dp[s.Length - 1];
        }
    }
}