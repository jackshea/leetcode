﻿namespace LeetCode.Problems.Easy;

/// 反转字符串中的单词 III
/// https://leetcode-cn.com/problems/reverse-words-in-a-string-iii/submissions/
public class P0557_ReverseWordsInAStringIII
{
    public string ReverseWords(string s)
    {
        var charArray = s.ToCharArray();
        var startIndex = 0;
        for (var i = 0; i < charArray.Length; i++)
            if (i == charArray.Length - 1)
            {
                ReverseString(charArray, startIndex, i);
            }
            else if (charArray[i] == ' ')
            {
                ReverseString(charArray, startIndex, i - 1);
                startIndex = i + 1;
            }

        return new string(charArray);
    }

    private void ReverseString(char[] s, int start, int end)
    {
        start = start > 0 ? start : 0;
        end = end < s.Length ? end : s.Length - 1;
        while (start < end)
        {
            var temp = s[start];
            s[start] = s[end];
            s[end] = temp;
            start++;
            end--;
        }
    }
}