using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 匹配子序列的单词数
    /// https://leetcode-cn.com/problems/number-of-matching-subsequences/
    public class P0792_NumberOfMatchingSubsequences
    {
        public int NumMatchingSubseq(string s, string[] words)
        {
            List<Node>[] heads = new List<Node>[26];
            int ans = 0;
            for (int i = 0; i < heads.Length; i++)
            {
                heads[i] = new List<Node>();
            }

            foreach (var word in words)
            {
                heads[word[0] - 'a'].Add(new Node
                {
                    Word = word,
                    Index = 0
                });
            }

            foreach (var c in s)
            {

                List<Node> pre = heads[c - 'a'];
                heads[c - 'a'] = new List<Node>();
                foreach (var node in pre)
                {
                    node.Index++;
                    if (node.Index == node.Word.Length)
                    {
                        ans++;
                    }
                    else
                    {
                        heads[node.Word[node.Index] - 'a'].Add(node);
                    }
                }
                pre.Clear();
            }

            return ans;
        }

        private class Node
        {
            public string Word;
            public int Index;
        }
    }
}