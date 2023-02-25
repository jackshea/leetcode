using System;

namespace LeetCode.Problems.Easy;

/// 玩筹码
/// https://leetcode-cn.com/problems/play-with-chips/
public class P1217_PlayWithChips
{
    public int MinCostToMoveChips(int[] chips)
    {
        var odd = 0;
        var even = 0;
        foreach (var chip in chips)
            if (chip % 2 == 0)
                odd++;
            else
                even++;

        return Math.Min(odd, even);
    }
}