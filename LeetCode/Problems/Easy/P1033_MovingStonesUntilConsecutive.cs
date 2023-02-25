using System;

namespace LeetCode.Problems.Easy;

/// 移动石子直到连续
/// https://leetcode-cn.com/problems/moving-stones-until-consecutive/
public class P1033_MovingStonesUntilConsecutive
{
    public int[] NumMovesStones(int a, int b, int c)
    {
        var pos = new[] { a, b, c };
        Array.Sort(pos);
        var min = 2;
        var max = pos[2] - pos[0] - 2;

        if (pos[0] + 1 == pos[1]) min--;
        if (pos[1] + 1 == pos[2]) min--;

        if (pos[0] + 2 == pos[1] || pos[1] + 2 == pos[2]) min = 1;

        return new[] { min, max };
    }
}