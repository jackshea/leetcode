using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 找到字符串中所有字母异位词
    /// https://leetcode-cn.com/problems/find-all-anagrams-in-a-string/
    public class P0438_FindAllAnagramsInAString
    {
        private int[] _targetChars = new int[26];
        private int[] _currentChars = new int[26];

        public IList<int> FindAnagrams(string s, string p)
        {
            IList<int> result = new List<int>();

            if (s.Length < p.Length)
            {
                return result;
            }

            foreach (var c in p)
            {
                _targetChars[c - 'a']++;
            }

            int leftIndex = 0;
            int rightIndex = 0;

            while (rightIndex < p.Length)
            {
                _currentChars[s[rightIndex++] - 'a']++;
            }

            if (IsSame())
            {
                result.Add(leftIndex);
            }

            while (rightIndex < s.Length)
            {
                _currentChars[s[leftIndex++] - 'a']--;
                _currentChars[s[rightIndex++] - 'a']++;
                if (IsSame())
                {
                    result.Add(leftIndex);
                }
            }

            return result;
        }

        private bool IsSame()
        {
            for (int i = 0; i < 26; i++)
            {
                if (_targetChars[i] != _currentChars[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}