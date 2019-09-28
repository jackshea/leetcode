using System;

namespace LeetCode.Problems
{
    /// 反转字符串中的单词 III
    /// https://leetcode-cn.com/problems/reverse-words-in-a-string-iii/submissions/
    public class P557_ReverseWordsInAStringIII
    {
        public string ReverseWords(string s)
        {
            var charArray = s.ToCharArray();
            int startIndex = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (i == charArray.Length - 1)
                {
                    ReverseString(charArray, startIndex, i);
                }
                else if (charArray[i] == ' ')
                {
                    ReverseString(charArray, startIndex, i - 1);
                    startIndex = i + 1;
                }
            }

            return new string(charArray);
        }

        private void ReverseString(char[] s, int start, int end)
        {
            start = start > 0 ? start : 0;
            end = end < s.Length ? end : s.Length - 1;
            while (start < end)
            {
                char temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                start++;
                end--;
            }
        }
    }
}