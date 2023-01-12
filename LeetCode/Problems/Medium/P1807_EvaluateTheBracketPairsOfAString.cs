using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Medium
{
    /// 替换字符串中的括号内容
    /// https://leetcode.cn/problems/evaluate-the-bracket-pairs-of-a-string/
    public class P1807_EvaluateTheBracketPairsOfAString
    {
        public string Evaluate(string s, IList<IList<string>> knowledge)
        {
            var wordDic = new Dictionary<string, string>();
            foreach (var pair in knowledge)
            {
                wordDic[pair[0]] = pair[1];
            }

            var sb = new StringBuilder();
            bool isReading = false;
            var word = new StringBuilder();
            foreach (var c in s)
            {
                if (c == '(')
                {
                    isReading = true;
                }
                else if (c == ')')
                {
                    isReading = false;
                    if (wordDic.TryGetValue(word.ToString(), out string target))
                    {
                        sb.Append(target);
                    }
                    else
                    {
                        sb.Append("?");
                    }

                    word.Length = 0;
                }
                else
                {
                    if (isReading)
                    {
                        word.Append(c);
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
            }

            return sb.ToString();
        }
    }
}