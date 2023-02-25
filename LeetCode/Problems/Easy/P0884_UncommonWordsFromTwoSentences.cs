using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 两句话中的不常见单词
/// https://leetcode-cn.com/problems/uncommon-words-from-two-sentences/
public class P0884_UncommonWordsFromTwoSentences
{
    public string[] UncommonFromSentences(string A, string B)
    {
        var word2Count = new Dictionary<string, int>();
        var words = (A + " " + B).Split(' ');
        foreach (var word in words)
            if (word2Count.ContainsKey(word))
                word2Count[word]++;
            else
                word2Count.Add(word, 1);

        var ans = new List<string>();
        foreach (var kvp in word2Count)
            if (kvp.Value == 1)
                ans.Add(kvp.Key);

        return ans.ToArray();
        //return word2Count.Where(p => p.Value == 1).Select(p => p.Key).ToArray();
    }
}