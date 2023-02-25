using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 剑指 Offer 50. 第一个只出现一次的字符
/// https://leetcode-cn.com/problems/di-yi-ge-zhi-chu-xian-yi-ci-de-zi-fu-lcof/
public class Offer50
{
    public char FirstUniqChar(string s)
    {
        var dic = new Dictionary<char, int>();
        foreach (var c in s)
            if (dic.ContainsKey(c))
                dic[c]++;
            else
                dic[c] = 1;

        foreach (var c in s)
            if (dic.TryGetValue(c, out var count) && count == 1)
                return c;

        return ' ';
    }
}