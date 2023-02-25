using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 单词拆分
/// https://leetcode-cn.com/problems/word-break/
public class P0139_WordBreak
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        var set = new HashSet<string>();
        foreach (var word in wordDict) set.Add(word);

        var dp = new bool[s.Length];
        for (var i = 0; i < s.Length; i++)
        for (var j = i; j >= 0; j--)
        {
            var isContains = set.Contains(s.Substring(j, i - j + 1));
            if (isContains && (j == 0 || (j > 0 && dp[j - 1])))
            {
                dp[i] = true;
                break;
            }
        }

        return dp[s.Length - 1];
    }
}