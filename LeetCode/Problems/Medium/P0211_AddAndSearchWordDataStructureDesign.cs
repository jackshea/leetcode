namespace LeetCode.Problems.Medium
{
    /// 添加与搜索单词 - 数据结构设计
    /// https://leetcode-cn.com/problems/add-and-search-word-data-structure-design/
    public class WordDictionary
    {
        private TrieNode root;
        /** Initialize your data structure here. */
        public WordDictionary()
        {
            root = new TrieNode();
        }

        /** Adds a word into the data structure. */
        public void AddWord(string word)
        {
            TrieNode node = root;
            for (var i = 0; i < word.Length; i++)
            {
                var c = word[i];
                var ci = c - 'a';
                if (node.Nexts[ci] == null)
                {
                    node.Nexts[ci] = new TrieNode();
                }

                node = node.Nexts[ci];
                if (i == word.Length - 1)
                {
                    node.IsWord = true;
                }
            }
        }

        /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
        public bool Search(string word)
        {
            return Search(root, word);
        }

        public bool Search(TrieNode node, string word)
        {
            if (word.Length == 0)
            {
                return node.IsWord;
            }
            for (int i = 0; i < word.Length; i++)
            {
                var c = word[i];
                if (c == '.')
                {
                    var substring = word.Substring(i + 1, word.Length - i - 1);
                    for (int j = 0; j < 26; j++)
                    {
                        if (node.Nexts[j] == null)
                        {
                            continue;
                        }

                        if (Search(node.Nexts[j], substring))
                        {
                            return true;
                        }
                    }

                    return false;
                }
                var ci = c - 'a';
                if (node.Nexts[ci] == null)
                {
                    return false;
                }

                node = node.Nexts[ci];

                if (i == word.Length - 1)
                {
                    return node.IsWord;
                }
            }

            return false;
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