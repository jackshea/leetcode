using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Problems.Easy;

/// 卡牌分组
/// https://leetcode-cn.com/problems/x-of-a-kind-in-a-deck-of-cards/
public class P0914_XOfAKindInADeckOfCards
{
    public bool HasGroupsSizeX(int[] deck)
    {
        if (deck.Length <= 1) return false;

        // 数字 -> 数量
        var dic = new Dictionary<int, int>();
        foreach (var n in deck)
            if (dic.ContainsKey(n))
                dic[n]++;
            else
                dic[n] = 1;

        if (dic.Count == 1) return true;

        var vList = dic.Values.ToList();
        var gcd = vList[0];
        for (var i = 1; i < vList.Count; i++)
        {
            gcd = GCD(gcd, vList[i]);
            if (gcd == 1) return false;
        }

        return true;
    }

    private int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
}