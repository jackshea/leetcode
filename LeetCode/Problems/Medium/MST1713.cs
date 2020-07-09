using System;

namespace LeetCode.Problems.Medium
{
    /// 面试题 17.13. 恢复空格
    /// https://leetcode-cn.com/problems/re-space-lcci/
    public class MST1713
    {
        public int Respace(string[] dictionary, string sentence)
        {
            var trie = new Trie();
            foreach (var word in dictionary)
            {
                trie.Insert(word);
            }

            int[] dp = new int[sentence.Length + 1];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = int.MaxValue;
            }

            dp[0] = 0;

            for (int i = 1; i <= sentence.Length; i++)
            {
                dp[i] = dp[i - 1] + 1;

                TrieNode cur = trie.Root;

                for (int j = i; j >= 1; j--)
                {
                    var trieIndex = sentence[j - 1] - 'a';
                    var nextNode = cur.Nexts[trieIndex];
                    if (nextNode == null)
                    {
                        break;
                    }
                    else if (nextNode.IsWord)
                    {
                        dp[i] = Math.Min(dp[i], dp[j - 1]);
                    }

                    if (dp[i] == 0)
                    {
                        break;
                    }

                    cur = nextNode;
                }
            }

            return dp[sentence.Length];
        }

        public class Trie
        {
            public TrieNode Root;
            /** Initialize your data structure here. */
            public Trie()
            {
                Root = new TrieNode();
            }

            /** Inserts a word into the trie. */
            public void Insert(string word)
            {
                TrieNode cur = Root;
                for (var i = word.Length - 1; i >= 0; i--)
                {
                    var c = word[i];
                    int nextI = c - 'a';
                    if (cur.Nexts[nextI] == null)
                    {
                        cur.Nexts[nextI] = new TrieNode();
                    }

                    cur = cur.Nexts[nextI];
                }

                cur.IsWord = true;
            }

            public bool Search(char[] chars, int start, int end)
            {
                TrieNode cur = Root;
                for (int i = end; i >= start; i--)
                {
                    var c = chars[i];
                    int nextI = c - 'a';
                    if (cur.Nexts[nextI] == null)
                    {
                        return false;
                    }

                    cur = cur.Nexts[nextI];
                }

                return cur.IsWord;
            }
        }

        public class TrieNode
        {
            public TrieNode()
            {
                Nexts = new TrieNode[26];
            }

            public bool IsWord { get; set; }
            public TrieNode[] Nexts { get; }
        }
    }
}