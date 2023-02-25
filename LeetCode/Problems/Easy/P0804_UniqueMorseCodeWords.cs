using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems.Easy;

/// 唯一摩尔斯密码词
/// https://leetcode-cn.com/problems/unique-morse-code-words/
public class P0804_UniqueMorseCodeWords
{
    private readonly string[] morseCodes =
    {
        ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.",
        "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
    };

    public int UniqueMorseRepresentations(string[] words)
    {
        var set = new HashSet<string>();
        foreach (var word in words) set.Add(Translate(word));

        return set.Count;
    }

    private string Translate(string word)
    {
        var sb = new StringBuilder();
        foreach (var c in word) sb.Append(morseCodes[c - 'a']);

        return sb.ToString();
    }
}