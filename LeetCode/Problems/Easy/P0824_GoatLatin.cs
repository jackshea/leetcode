using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Easy;

/// 山羊拉丁文
/// https://leetcode-cn.com/problems/goat-latin/
public class P0824_GoatLatin
{
    private readonly HashSet<char> vowels = new("aeiouAEIOU");

    public string ToGoatLatin(string S)
    {
        var words = S.Split(' ');
        var sb = new StringBuilder();
        for (var i = 0; i < words.Length; i++)
        {
            if (i != 0) sb.Append(' ');

            sb.Append(Convert(words[i], i));
        }

        return sb.ToString();
    }

    public string Convert(string word, int index)
    {
        if (word.Length == 0) return word;
        var sb = new StringBuilder();
        if (vowels.Contains(word[0]))
        {
            sb.Append(word + "ma");
        }
        else
        {
            sb.Append(word.Substring(1, word.Length - 1) + word[0]);
            sb.Append("ma");
        }

        for (var i = 0; i < index + 1; i++) sb.Append('a');

        return sb.ToString();
    }
}