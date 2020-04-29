using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 回文排列
    /// https://leetcode-cn.com/problems/palindrome-permutation-lcci/
    public class MST0104
    {
        public bool CanPermutePalindrome(string s)
        {
            var chars = CountChars(s);
            int oddCount = 0;
            foreach (var count in chars.Values)
            {
                if (count % 2 != 0)
                {
                    oddCount++;
                }
            }

            return oddCount < 2;
        }

        private Dictionary<char, int> CountChars(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic[c] = 1;
                }
            }

            return dic;
        }
    }
}