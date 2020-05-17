using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 单词频率
    /// https://leetcode-cn.com/problems/words-frequency-lcci/
    public class WordsFrequency
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        public WordsFrequency(string[] book)
        {
            foreach (var word in book)
            {
                dic.TryGetValue(word, out int count);
                dic[word] = count + 1;
            }
        }

        public int Get(string word)
        {
            dic.TryGetValue(word, out int count);
            return count;
        }
    }
}