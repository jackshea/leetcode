using System;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 词典中最长的单词
    /// https://leetcode-cn.com/problems/longest-word-in-dictionary/
    public class P0720_LongestWordInDictionary
    {
        public string LongestWord(string[] words)
        {
            Array.Sort(words);
            string ans = string.Empty;
            HashSet<string> set = new HashSet<string>();
            set.Add(ans);

            foreach (var word in words)
            {
                if (set.Contains(word.Substring(0, word.Length - 1)))
                {
                    if (word.Length > ans.Length)
                    {
                        ans = word;
                    }

                    set.Add(word);
                }
            }

            return ans;
        }
    }
}