using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 键盘行
    /// https://leetcode-cn.com/problems/keyboard-row/
    public class P0500_KeyboardRow
    {
        public string[] FindWords(string[] words)
        {
            string[] chars = new[] { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            Dictionary<char, int> charValue = new Dictionary<char, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                string s = chars[i];
                foreach (var c in s)
                {
                    charValue.Add(c, i + 1);
                    charValue.Add(char.ToUpper(c), i + 1);
                }
            }

            List<string> result = new List<string>();
            foreach (var word in words)
            {
                bool isMatch = true;
                if (word.Length > 1)
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        if (charValue[word[i]] != charValue[word[0]])
                        {
                            isMatch = false;
                        }
                    }
                }
                if (isMatch)
                {
                    result.Add(word);
                }
            }

            return result.ToArray();
        }
    }
}