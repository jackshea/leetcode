using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Easy;

/// 最短完整词
/// https://leetcode-cn.com/problems/shortest-completing-word/
public class P0748_ShortestCompletingWord
{
    public string ShortestCompletingWord(string licensePlate, string[] words)
    {
        var licenseDic = GetDic(licensePlate);
        var count = licenseDic.Values.Sum();

        var ans = string.Empty;
        var length = int.MaxValue;

        foreach (var word in words)
        {
            if (word.Length < count) continue;

            var wordDic = GetDic(word);
            var isMatch = true;
            foreach (var kvp in licenseDic)
            {
                var v = 0;
                if (!wordDic.TryGetValue(kvp.Key, out v) || v < kvp.Value)
                {
                    isMatch = false;
                    break;
                }
            }

            if (isMatch && word.Length < length)
            {
                ans = word;
                length = word.Length;
            }
        }

        return ans;
    }

    private Dictionary<char, int> GetDic(string word)
    {
        var dic = new Dictionary<char, int>();
        foreach (var c in word)
        {
            if (!char.IsLetter(c)) continue;

            var toLower = char.ToLower(c);
            if (dic.ContainsKey(toLower))
                dic[toLower]++;
            else
                dic[toLower] = 1;
        }

        return dic;
    }
}