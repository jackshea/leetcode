using System;

namespace LeetCode.Problems.Easy
{
    /// 最大重复子字符串
    /// https://leetcode-cn.com/problems/maximum-repeating-substring/
    public class P1668_MaximumRepeatingSubstring
    {
        public int MaxRepeating(string sequence, string word)
        {
            int ans = 0;
            int repeat = 0;
            int start = 0;
            while (start <= sequence.Length)
            {
                var indexOf = sequence.IndexOf(word, start);

                if (indexOf == start)
                {
                    repeat++;
                }
                else
                {
                    repeat = 1;
                }

                ans = Math.Max(ans, repeat);

                if (indexOf < 0)
                {
                    break;
                }

                start = indexOf + word.Length;
            }

            return ans;
        }
    }
}