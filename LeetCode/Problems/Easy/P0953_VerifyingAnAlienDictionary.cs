using System;

namespace LeetCode.Problems.Easy;

/// 验证外星语词典
/// https://leetcode-cn.com/problems/verifying-an-alien-dictionary/
public class P0953_VerifyingAnAlienDictionary
{
    private readonly int[] dicOrder = new int[26];

    public bool IsAlienSorted(string[] words, string order)
    {
        for (var i = 0; i < order.Length; i++)
        {
            var c = order[i] - 'a';
            dicOrder[c] = i;
        }

        for (var i = 0; i < words.Length - 1; i++)
            if (AlienWordComparer(words[i], words[i + 1]) > 0)
                return false;

        return true;
    }

    private int AlienWordComparer(string a, string b)
    {
        for (var i = 0; i < a.Length; i++)
        {
            if (i >= b.Length) return 1;

            var compare = dicOrder[a[i] - 'a'] - dicOrder[b[i] - 'a'];
            if (compare != 0) return Math.Sign(compare);
        }

        if (a.Length == b.Length) return 0;
        return -1;
    }
}