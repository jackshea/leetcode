using System.Text;

namespace LeetCode.Problems.Easy;

public class Offer58_I
{
    /// 剑指 Offer 58 - I. 翻转单词顺序
    /// https://leetcode-cn.com/problems/fan-zhuan-dan-ci-shun-xu-lcof/
    public string ReverseWords(string s)
    {
        var split = s.Split(' ');
        var sb = new StringBuilder();
        for (var i = split.Length - 1; i >= 0; i--)
        {
            var word = split[i];
            if (word.Length == 0) continue;
            if (sb.Length != 0) sb.Append(" ");
            sb.Append(word);
        }

        return sb.ToString();
    }
}