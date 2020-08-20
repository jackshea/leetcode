﻿namespace LeetCode.Problems.Medium
{
    /// 扫雷游戏
    /// https://leetcode-cn.com/problems/minesweeper/
    public class P0529_MineSweeper
    {
        public char[][] UpdateBoard(char[][] board, int[] click)
        {
            var r = click[0];
            var c = click[1];

            var pos = board[r][c];
            if (pos == 'M')
            {
                board[r][c] = 'X';
                return board;
            }

            if (pos != 'E')
            {
                return board;
            }

            board[r][c] = 'B';
            int nearMineCount = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        continue;
                    }
                    int ri = r + i;
                    int cj = c + j;
                    if (ri >= 0 && ri < board.Length && cj >= 0 && cj < board[0].Length && board[ri][cj] == 'M')
                    {
                        nearMineCount++;
                    }
                }
            }

            if (nearMineCount > 0)
            {
                board[r][c] = nearMineCount.ToString()[0];
            }
            else
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        if (i == 0 && j == 0)
                        {
                            continue;
                        }
                        int ri = r + i;
                        int cj = c + j;
                        if (ri >= 0 && ri < board.Length && cj >= 0 && cj < board[0].Length)
                        {
                            UpdateBoard(board, new[] { ri, cj });
                        }
                    }
                }
            }

            return board;
        }
    }
}