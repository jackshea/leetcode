using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 至少有K个重复字符的最长子串
    /// https://leetcode-cn.com/problems/longest-substring-with-at-least-k-repeating-characters/
    public class P0395_LongestSubstringWithAtLeastKRepeatingCharacters
    {
        private int[,] charCounter;
        public int LongestSubstring(string s, int k)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            charCounter = new int[26, s.Length];
            charCounter[s[0] - 'a', 0] = 1;
            for (var i = 1; i < s.Length; i++)
            {
                var c = s[i];
                for (int j = 0; j < 26; j++)
                {
                    charCounter[j, i] = charCounter[j, i - 1];
                    if (j == c - 'a')
                    {
                        charCounter[j, i]++;
                    }
                }
            }

            return LongestSubstring(s, k, 0, s.Length - 1);
        }

        private int LongestSubstring(string s, int k, int left, int right)
        {
            if (right - left + 1 < k)
            {
                return 0;
            }

            int last = left;
            for (int i = left; i <= right; i++)
            {
                int c = s[i] - 'a';
                if (GetCharCount(c, left, right) < k)
                {
                    return Math.Max(LongestSubstring(s, k, left, i - 1), LongestSubstring(s, k, i + 1, right));
                }
            }

            return right - left + 1;
        }

        private int GetCharCount(int c, int left, int right)
        {
            if (left == 0)
            {
                return charCounter[c, right];
            }

            return charCounter[c, right] - charCounter[c, left - 1];
        }
    }
}