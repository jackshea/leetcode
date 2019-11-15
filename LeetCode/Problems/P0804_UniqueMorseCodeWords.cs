using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    /// 唯一摩尔斯密码词
    /// https://leetcode-cn.com/problems/unique-morse-code-words/
    public class P0804_UniqueMorseCodeWords
    {
        private string[] morseCodes = new string[]
        {
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.",
            "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
        };

        public int UniqueMorseRepresentations(string[] words)
        {
            HashSet<string> set = new HashSet<string>();
            foreach (var word in words)
            {
                set.Add(Translate(word));
            }

            return set.Count;
        }

        private string Translate(string word)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var c in word)
            {
                sb.Append(morseCodes[c - 'a']);
            }

            return sb.ToString();
        }
    }

}
