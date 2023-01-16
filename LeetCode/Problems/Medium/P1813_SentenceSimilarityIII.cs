using System;

namespace LeetCode.Problems.Medium
{
    /// 句子相似性 III
    /// https://leetcode.cn/problems/sentence-similarity-iii/
    public class P1813_SentenceSimilarityIII
    {
        public bool AreSentencesSimilar(string sentence1, string sentence2)
        {
            var words1 = sentence1.Split(' ');
            var words2 = sentence2.Split(' ');
            int n1 = words1.Length;
            int n2 = words2.Length;
            int i = 0, j = 0;
            while (i < n1 && i < n2 && words1[i] == words2[i])
            {
                i++;
            }
            while (j < n1 - i && j < n2 - i && words1[n1 - 1 - j] == words2[n2 - 1 - j])
            {
                j++;
            }

            return i + j == Math.Min(n1, n2);
        }
    }
}