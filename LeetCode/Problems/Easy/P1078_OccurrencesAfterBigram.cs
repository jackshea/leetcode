using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// Bigram 分词
/// https://leetcode-cn.com/problems/occurrences-after-bigram/
public class P1078_OccurrencesAfterBigram
{
    public string[] FindOcurrences(string text, string first, string second)
    {
        var ans = new List<string>();
        var words = text.Split(' ');
        for (var i = 0; i < words.Length - 2; i++)
            if (words[i] == first && words[i + 1] == second)
                ans.Add(words[i + 2]);

        return ans.ToArray();
    }
}