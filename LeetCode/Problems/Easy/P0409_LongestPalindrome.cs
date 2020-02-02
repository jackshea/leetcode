using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 最长回文串
    /// https://leetcode-cn.com/problems/longest-palindrome/submissions/
    public class P0409_LongestPalindrome
    {
        public int LongestPalindrome(string s)
        {
            Dictionary<char, int> charDic = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (charDic.ContainsKey(c))
                {
                    charDic[c]++;
                }
                else
                {
                    charDic[c] = 1;
                }
            }

            int result = 0;
            bool hasSingleChar = false;
            foreach (var kvp in charDic)
            {
                if (kvp.Value % 2 == 1)
                {
                    hasSingleChar = true;
                    result += kvp.Value - 1;
                }
                else
                {
                    result += kvp.Value;
                }
            }

            if (hasSingleChar)
            {
                result++;
            }

            return result;
        }
    }
}