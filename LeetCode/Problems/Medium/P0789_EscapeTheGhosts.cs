using System;

namespace LeetCode.Problems.Medium;

/// 逃脱阻碍者
/// https://leetcode-cn.com/problems/escape-the-ghosts/
public class P0789_EscapeTheGhosts
{
    public bool EscapeGhosts(int[][] ghosts, int[] target)
    {
        var dist = Math.Abs(target[0]) + Math.Abs(target[1]);
        foreach (var ghost in ghosts)
            if (Math.Abs(ghost[0] - target[0]) + Math.Abs(ghost[1] - target[1]) <= dist)
                return false;

        return true;
    }
}