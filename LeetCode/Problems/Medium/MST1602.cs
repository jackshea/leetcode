using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 单词频率
/// https://leetcode-cn.com/problems/words-frequency-lcci/
public class WordsFrequency
{
    private readonly Dictionary<string, int> dic = new();

    public WordsFrequency(string[] book)
    {
        foreach (var word in book)
        {
            dic.TryGetValue(word, out var count);
            dic[word] = count + 1;
        }
    }

    public int Get(string word)
    {
        dic.TryGetValue(word, out var count);
        return count;
    }
}