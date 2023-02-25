using System;
using System.Text;

namespace LeetCode.Problems.Medium;

/// 翻转字符串里的单词
/// https://leetcode-cn.com/problems/reverse-words-in-a-string/
public class P0151_ReverseWordsInAString
{
    public string ReverseWords(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";

        var words = s.Split(' ');
        Array.Reverse(words);
        var sb = new StringBuilder();
        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];
            if (string.IsNullOrWhiteSpace(word)) continue;
            if (sb.Length != 0) sb.Append(' ');
            sb.Append(word);
        }

        return sb.ToString();
    }
}

// 不使用语言特性的API
public class P0151_ReverseWordsInAString_1
{
    private char[] chars;

    public string ReverseWords(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return s;

        chars = s.ToCharArray();

        // 反转整个字符串
        Reverse(0, s.Length - 1);

        // 找到单词并反转
        for (var i = 0; i < chars.Length; i++)
        {
            if (chars[i] == ' ')
                continue;

            var j = i + 1;
            while (j < chars.Length && chars[j] != ' ') j++;
            Reverse(i, j - 1);
            i = j;
        }

        // 去除多余的空格
        var len = 0;
        for (var i = 0; i < chars.Length; i++)
        {
            if (chars[i] == ' ' && (len == 0 || chars[len - 1] == ' ')) continue;

            chars[len++] = chars[i];
        }

        if (chars[len - 1] == ' ') len--;

        return new string(chars, 0, len);
    }

    private void Reverse(int start, int end)
    {
        while (start < end)
        {
            var temp = chars[start];
            chars[start] = chars[end];
            chars[end] = temp;
            start++;
            end--;
        }
    }
}