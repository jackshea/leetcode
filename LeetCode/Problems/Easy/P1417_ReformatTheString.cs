using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Easy
{
    /// 重新格式化字符串
    /// https://leetcode-cn.com/problems/reformat-the-string/
    public class P1417_ReformatTheString
    {
        public string Reformat(string s)
        {
            List<char> letters = new List<char>();
            List<char> digits = new List<char>();
            foreach (var c in s)
            {
                if (char.IsLetter(c))
                {
                    letters.Add(c);
                }
                else
                {
                    digits.Add(c);
                }
            }

            if (Math.Abs(letters.Count - digits.Count) > 1)
            {
                return string.Empty;
            }

            List<char> longer;
            List<char> shorter;
            if (letters.Count > digits.Count)
            {
                longer = letters;
                shorter = digits;
            }
            else
            {
                longer = digits;
                shorter = letters;
            }

            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < shorter.Count; i++)
            {
                ans.Append(longer[i]);
                ans.Append(shorter[i]);
            }

            if (longer.Count > shorter.Count)
            {
                ans.Append(longer[longer.Count - 1]);
            }

            return ans.ToString();
        }
    }
}