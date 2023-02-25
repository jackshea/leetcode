using System;

namespace LeetCode.Problems.Medium;

/// 面试题 17.13. 恢复空格
/// https://leetcode-cn.com/problems/re-space-lcci/
public class MST1713
{
    public int Respace(string[] dictionary, string sentence)
    {
        var trie = new Trie();
        foreach (var word in dictionary) trie.Insert(word);

        var dp = new int[sentence.Length + 1];
        for (var i = 0; i < dp.Length; i++) dp[i] = int.MaxValue;

        dp[0] = 0;

        for (var i = 1; i <= sentence.Length; i++)
        {
            dp[i] = dp[i - 1] + 1;

            var cur = trie.Root;

            for (var j = i; j >= 1; j--)
            {
                var trieIndex = sentence[j - 1] - 'a';
                var nextNode = cur.Nexts[trieIndex];
                if (nextNode == null)
                    break;
                if (nextNode.IsWord) dp[i] = Math.Min(dp[i], dp[j - 1]);

                if (dp[i] == 0) break;

                cur = nextNode;
            }
        }

        return dp[sentence.Length];
    }

    public class Trie
    {
        public TrieNode Root;

        /**
         * Initialize your data structure here.
         */
        public Trie()
        {
            Root = new TrieNode();
        }

        /**
         * Inserts a word into the trie.
         */
        public void Insert(string word)
        {
            var cur = Root;
            for (var i = word.Length - 1; i >= 0; i--)
            {
                var c = word[i];
                var nextI = c - 'a';
                if (cur.Nexts[nextI] == null) cur.Nexts[nextI] = new TrieNode();

                cur = cur.Nexts[nextI];
            }

            cur.IsWord = true;
        }

        public bool Search(char[] chars, int start, int end)
        {
            var cur = Root;
            for (var i = end; i >= start; i--)
            {
                var c = chars[i];
                var nextI = c - 'a';
                if (cur.Nexts[nextI] == null) return false;

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