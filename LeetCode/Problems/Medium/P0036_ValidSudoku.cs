﻿namespace LeetCode.Problems.Medium;

/// 有效的数独
/// https://leetcode-cn.com/problems/valid-sudoku/
public class P0036_ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        // 验证行
        var numCounter = new int[board[0].Length];
        for (var i = 0; i < board.Length; i++)
        {
            ResetCounter(numCounter);
            for (var j = 0; j < board[0].Length; j++)
            {
                var c = board[i][j];
                if (c == '.') continue;
                numCounter[c - '1']++;
                if (numCounter[c - '1'] > 1) return false;
            }
        }

        // 验证列
        for (var i = 0; i < board[0].Length; i++)
        {
            ResetCounter(numCounter);
            for (var j = 0; j < board.Length; j++)
            {
                var c = board[j][i];
                if (c == '.') continue;
                numCounter[c - '1']++;
                if (numCounter[c - '1'] > 1) return false;
            }
        }

        // 验证九宫
        for (var i = 0; i < 3; i++)
        for (var j = 0; j < 3; j++)
        {
            // i,j 是九宫左上角坐标
            ResetCounter(numCounter);
            for (var k = 0; k < 3; k++)
            for (var l = 0; l < 3; l++)
            {
                var c = board[i * 3 + k][j * 3 + l];
                if (c == '.') continue;
                numCounter[c - '1']++;
                if (numCounter[c - '1'] > 1) return false;
            }
        }

        return true;
    }

    private void ResetCounter(int[] counter)
    {
        for (var i = 0; i < counter.Length; i++) counter[i] = 0;
    }
}