﻿using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 情感丰富的文字
    /// https://leetcode-cn.com/problems/expressive-words/
    public class P0809_ExpressiveWords
    {
        public int ExpressiveWords(string s, string[] words)
        {
            var baseWord = new WordAnalysis(s);
            int ans = 0;
            foreach (var word in words)
            {
                if (s == word)
                {
                    ans++;
                    continue;
                }

                var wordAnalysis = new WordAnalysis(word);
                if (baseWord.Key != wordAnalysis.Key)
                {
                    continue;
                }

                bool check = true;
                for (int i = 0; i < baseWord.Counter.Count; i++)
                {
                    if (baseWord.Counter[i] == wordAnalysis.Counter[i])
                    {
                        continue;
                    }

                    if (baseWord.Counter[i] >= 3 && baseWord.Counter[i] >= wordAnalysis.Counter[i])
                    {
                        continue;
                    }

                    check = false;
                    break;
                }

                ans += check ? 1 : 0;
            }

            return ans;
        }

        public class WordAnalysis
        {
            public string Key { get; }
            public List<int> Counter { get; }

            public WordAnalysis(string word)
            {
                Counter = new List<int>();
                if (word == string.Empty)
                {
                    return;
                }
                List<char> chars = new List<char>();
                chars.Add(word[0]);
                int cnt = 1;
                for (int i = 1; i < word.Length; i++)
                {
                    if (word[i] == word[i - 1])
                    {
                        cnt++;
                    }
                    else
                    {
                        Counter.Add(cnt);
                        chars.Add(word[i]);
                        cnt = 1;
                    }
                }
                Counter.Add(cnt);
                Key = new string(chars.ToArray());
            }
        }
    }
}