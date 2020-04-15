using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 单词接龙
    /// https://leetcode-cn.com/problems/word-ladder/
    /// 超时。。。
    public class P0127_WordLadder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> visited = new HashSet<string>();
            Queue<string> q = new Queue<string>();
            q.Enqueue(beginWord);
            visited.Add(beginWord);
            int len = 1;
            while (q.Count > 0)
            {
                int count = q.Count;
                len++;
                for (int i = 0; i < count; i++)
                {
                    var top = q.Dequeue();
                    foreach (var word in wordList)
                    {
                        if (visited.Contains(word))
                        {
                            continue;
                        }

                        if (IsNext(top, word))
                        {
                            if (endWord == word)
                            {
                                return len;
                            }
                            visited.Add(word);
                            q.Enqueue(word);
                        }
                    }
                }
            }

            return 0;
        }

        private bool IsNext(string start, string next)
        {
            int diff = 0;
            for (int i = 0; i < start.Length; i++)
            {
                if (start[i] != next[i])
                {
                    diff++;
                }
            }

            return diff == 1;
        }
    }
}