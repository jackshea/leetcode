using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 交换字符串中的元素
    /// https://leetcode-cn.com/problems/smallest-string-with-swaps/
    public class P1202_SmallestStringWithSwaps
    {
        public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs)
        {
            char[] ans = new char[s.Length];
            List<int>[] adj = new List<int>[s.Length];
            for (int i = 0; i < adj.Length; i++)
            {
                adj[i] = new List<int>();
            }

            foreach (var pair in pairs)
            {
                adj[pair[0]].Add(pair[1]);
                adj[pair[1]].Add(pair[0]);
            }

            bool[] isVisited = new bool[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                if (isVisited[i])
                {
                    continue;
                }

                isVisited[i] = true;
                List<int> exchangeSet = new List<int>();
                exchangeSet.Add(i);
                Queue<int> q = new Queue<int>();
                q.Enqueue(i);
                while (q.Count != 0)
                {
                    int count = q.Count;
                    for (int j = 0; j < count; j++)
                    {
                        var top = q.Dequeue();
                        foreach (var ad in adj[top])
                        {
                            if (isVisited[ad])
                            {
                                continue;
                            }

                            isVisited[ad] = true;
                            exchangeSet.Add(ad);
                            q.Enqueue(ad);
                        }
                    }
                }

                char[] selectedChars = new char[exchangeSet.Count];
                for (int j = 0; j < selectedChars.Length; j++)
                {
                    selectedChars[j] = s[exchangeSet[j]];
                }
                Array.Sort(selectedChars);
                exchangeSet.Sort();
                for (int j = 0; j < selectedChars.Length; j++)
                {
                    ans[exchangeSet[j]] = selectedChars[j];
                }
            }

            return new string(ans);
        }
    }
}