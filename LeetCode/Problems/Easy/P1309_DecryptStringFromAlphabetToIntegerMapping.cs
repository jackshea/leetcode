using System.Text;

namespace LeetCode.Problems
{
    /// 解码字母到整数映射
    /// https://leetcode-cn.com/problems/decrypt-string-from-alphabet-to-integer-mapping/
    public class P1309_DecryptStringFromAlphabetToIntegerMapping
    {
        public string FreqAlphabets(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '#')
                {
                    sb.Remove(sb.Length - 2, 2);
                    var decode = Decode(new string(new[] { s[i - 2], s[i - 1] }));
                    sb.Append(decode);
                }
                else
                {
                    sb.Append(Decode(c.ToString()));
                }
            }

            return sb.ToString();
        }

        private char Decode(string n)
        {
            return (char)('a' - 1 + int.Parse(n));
        }
    }
}