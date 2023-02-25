using System;

namespace LeetCode.Problems.Easy;

/// 最好的扑克手牌
/// https://leetcode.cn/problems/best-poker-hand/
public class P2347_BestPokerHand
{
    public string BestHand(int[] ranks, char[] suits)
    {
        if (IsFlush(suits)) return "Flush";
        Array.Sort(ranks);
        var sameCount = SameCount(ranks);
        switch (sameCount)
        {
            case 1:
                return "High Card";
            case 2:
                return "Pair";
            default:
                return "Three of a Kind";
        }
    }

    public bool IsFlush(char[] suits)
    {
        for (var i = 1; i < suits.Length; i++)
            if (suits[i] != suits[i - 1])
                return false;

        return true;
    }

    public int SameCount(int[] ranks)
    {
        var count = 1;
        var ans = 1;
        for (var i = 1; i < ranks.Length; i++)
        {
            if (ranks[i] == ranks[i - 1])
                count++;
            else
                count = 1;

            ans = Math.Max(ans, count);
        }

        return ans;
    }
}