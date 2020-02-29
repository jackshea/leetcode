using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 无重复字符的最长子串
    /// https://leetcode-cn.com/problems/longest-substring-without-repeating-characters/
    public class P0003_LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            if (s.Length == 1)
            {
                return 1;
            }

            var charArray = s.ToCharArray();
            int maxLength = 0;
            int left = 0, right = 0;
            for (int i = 1; i < charArray.Length; i++)
            {
                for (int j = right; j >= left; j--)
                {
                    if (charArray[i] == charArray[j])
                    {
                        left = j + 1;
                    }
                }

                right = i;
                if (right - left + 1 > maxLength)
                {
                    maxLength = right - left + 1;
                }
            }

            return maxLength;
        }
    }
}