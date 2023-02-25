using System;

namespace LeetCode.Problems.Hard;

/// 地下城游戏
/// https://leetcode-cn.com/problems/dungeon-game/
public class P0174_DungeonGame
{
    private int[,] miniHp;

    public int CalculateMinimumHP(int[][] dungeon)
    {
        miniHp = new int[dungeon.Length, dungeon[0].Length];
        return GetMiniHp(dungeon, 0, 0);
    }

    private int GetMiniHp(int[][] dungeon, int r, int c)
    {
        if (r >= dungeon.Length || c >= dungeon[0].Length) return int.MaxValue;

        if (miniHp[r, c] != 0) return miniHp[r, c];

        if (r == dungeon.Length - 1 && c == dungeon[0].Length - 1)
        {
            miniHp[r, c] = dungeon[r][c] >= 0 ? 1 : 1 - dungeon[r][c];
            return miniHp[r, c];
        }

        var nearMin = Math.Min(GetMiniHp(dungeon, r, c + 1), GetMiniHp(dungeon, r + 1, c));
        miniHp[r, c] = nearMin - dungeon[r][c];
        if (miniHp[r, c] < 1) miniHp[r, c] = 1;
        return miniHp[r, c];
    }
}