using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 最长回文串
/// https://leetcode-cn.com/problems/longest-palindrome/submissions/
public class P0409_LongestPalindrome
{
    public int LongestPalindrome(string s)
    {
        var charDic = new Dictionary<char, int>();
        foreach (var c in s)
            if (charDic.ContainsKey(c))
                charDic[c]++;
            else
                charDic[c] = 1;

        var result = 0;
        var hasSingleChar = false;
        foreach (var kvp in charDic)
            if (kvp.Value % 2 == 1)
            {
                hasSingleChar = true;
                result += kvp.Value - 1;
            }
            else
            {
                result += kvp.Value;
            }

        if (hasSingleChar) result++;

        return result;
    }
}