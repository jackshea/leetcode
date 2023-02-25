using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 最大单词长度乘积
/// https://leetcode-cn.com/problems/maximum-product-of-word-lengths/
public class P0318_MaximumProductOfWordLengths
{
    public int MaxProduct(string[] words)
    {
        var bitMask = new Dictionary<string, int>();
        foreach (var word in words)
        {
            var mask = 0;
            foreach (var c in word) mask |= 1 << (c - 'a');
            bitMask[word] = mask;
        }

        var ans = 0;
        for (var i = 0; i < words.Length; i++)
        {
            var w1 = words[i];
            var m1 = bitMask[w1];
            for (var j = i + 1; j < words.Length; j++)
            {
                var w2 = words[j];
                var m2 = bitMask[w2];
                if ((m1 & m2) == 0) ans = Math.Max(ans, w1.Length * w2.Length);
            }
        }

        return ans;
    }
}