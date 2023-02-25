using System.Text;

namespace LeetCode.Problems.Medium;

/// 将句子排序
/// https://leetcode-cn.com/problems/sorting-the-sentence/
public class P1859_SortingTheSentence
{
    public string SortSentence(string s)
    {
        var words = s.Split(' ');
        var newWords = new string[words.Length + 1];
        foreach (var word in words)
        {
            var num = 0;
            var w = "";
            for (var i = 0; i < word.Length; i++)
            {
                var c = word[i];
                if (char.IsDigit(c))
                {
                    num = num * 10 + c - '0';
                    if (string.IsNullOrEmpty(w)) w = word.Substring(0, i);
                }

                newWords[num] = w;
            }
        }

        var sb = new StringBuilder();
        for (var i = 1; i < newWords.Length; i++)
        {
            var newWord = newWords[i];
            if (sb.Length != 0) sb.Append(" ");
            sb.Append(newWord);
        }

        return sb.ToString();
    }
}