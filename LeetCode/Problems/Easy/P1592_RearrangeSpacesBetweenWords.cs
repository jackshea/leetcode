using System.Linq;
using System.Text;

namespace LeetCode.Problems.Easy
{
    /// 重新排列单词间的空格
    /// https://leetcode-cn.com/problems/rearrange-spaces-between-words/
    public class P1592_RearrangeSpacesBetweenWords
    {
        public string ReorderSpaces(string text)
        {
            int spaceCount = 0;
            foreach (var c in text)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
            }

            var words = text.Split(' ');
            var wordsCount = words.Count(p => !string.IsNullOrWhiteSpace(p));
            int space = 0;
            if (wordsCount > 1)
            {
                space = (spaceCount) / (wordsCount - 1);
            }
            StringBuilder sb = new StringBuilder();
            bool first = true;
            foreach (var word in words)
            {
                if (string.IsNullOrWhiteSpace(word))
                {
                    continue;
                }

                if (!first)
                {
                    sb.Append(' ', space);
                }

                first = false;
                sb.Append(word);
            }

            sb.Append(' ', spaceCount - space * (wordsCount - 1));
            return sb.ToString();
        }
    }
}