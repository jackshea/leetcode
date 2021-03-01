using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 单词替换
    /// https://leetcode-cn.com/problems/replace-words/
    public class P0648_ReplaceWords
    {
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            var trie = new Trie();
            foreach (var word in dictionary)
            {
                trie.Insert(word);
            }

            var words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string prefix = trie.GetShortestPrefix(words[i]);
                words[i] = string.IsNullOrEmpty(prefix) ? words[i] : prefix;
            }

            return string.Join(' ', words);
        }

        public class Trie
        {
            private TrieNode root;
            /** Initialize your data structure here. */
            public Trie()
            {
                root = new TrieNode();
            }

            /** Inserts a word into the trie. */
            public void Insert(string word)
            {
                TrieNode cur = root;
                for (var i = 0; i < word.Length; i++)
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

            /** Returns if the word is in the trie. */
            public bool Search(string word)
            {
                TrieNode cur = root;
                for (var i = 0; i < word.Length; i++)
                {
                    var c = word[i];
                    int nextI = c - 'a';
                    if (cur.Nexts[nextI] == null)
                    {
                        return false;
                    }

                    cur = cur.Nexts[nextI];
                }

                return cur.IsWord;
            }

            /** Returns if there is any word in the trie that starts with the given prefix. */
            public bool StartsWith(string prefix)
            {
                TrieNode cur = root;
                for (var i = 0; i < prefix.Length; i++)
                {
                    var c = prefix[i];
                    int nextI = c - 'a';
                    if (cur.Nexts[nextI] == null)
                    {
                        return false;
                    }

                    cur = cur.Nexts[nextI];
                }

                return true;
            }

            public string GetShortestPrefix(string word)
            {
                TrieNode cur = root;
                for (var i = 0; i < word.Length; i++)
                {
                    var c = word[i];
                    int nextI = c - 'a';
                    if (cur.Nexts[nextI] == null)
                    {
                        return string.Empty;
                    }

                    cur = cur.Nexts[nextI];
                    if (cur.IsWord)
                    {
                        return word.Substring(0, i + 1);
                    }
                }

                return word;
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