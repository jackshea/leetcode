using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 有效的字母异位词
    /// https://leetcode-cn.com/problems/valid-anagram/
    public class P0242_ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> chars2Count = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (chars2Count.ContainsKey(c))
                {
                    chars2Count[c]++;
                }
                else
                {
                    chars2Count[c] = 1;
                }
            }

            foreach (var c in t)
            {
                if (!chars2Count.ContainsKey(c))
                {
                    return false;
                }

                chars2Count[c]--;
                if (chars2Count[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}