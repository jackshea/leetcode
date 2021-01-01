using System.Collections.Generic;

namespace LeetCode.Problems.Easy
{
    /// 统计一致字符串的数目
    /// https://leetcode-cn.com/problems/count-the-number-of-consistent-strings/
    public class P1684_CountTheNumberOfConsistentStrings
    {
        public int CountConsistentStrings(string allowed, string[] words)
        {
            HashSet<char> charSet = new HashSet<char>();
            foreach (var c in allowed)
            {
                charSet.Add(c);
            }

            int ans = 0;
            foreach (var word in words)
            {
                bool check = true;
                foreach (char c in word)
                {
                    if (!charSet.Contains(c))
                    {
                        check = false;
                        break;
                    }
                }

                if (check)
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}