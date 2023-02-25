using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 蛇梯棋
/// https://leetcode-cn.com/problems/snakes-and-ladders/
public class P0909_SnakesAndLadders
{
    public int SnakesAndLadders(int[][] board)
    {
        var m = board.Length;
        var n = board[0].Length;
        if (m * n <= 7) return 1;

        var longBoard = new int[m * n + 1];
        var lIndex = 1;
        var dir = true;
        for (var i = m - 1; i >= 0; i--)
        {
            if (dir)
                for (var j = 0; j < n; j++)
                    longBoard[lIndex++] = board[i][j];
            else
                for (var j = n - 1; j >= 0; j--)
                    longBoard[lIndex++] = board[i][j];

            dir = !dir;
        }

        var step = 0;
        var q = new Queue<int>();
        var visited = new HashSet<int>();
        q.Enqueue(1);
        visited.Add(1);
        while (q.Count > 0)
        {
            step++;
            var qCount = q.Count;
            for (var i = 0; i < qCount; i++)
            {
                var top = q.Dequeue();
                if (top >= longBoard.Length - 6) return step;

                for (var j = 1; j <= 6; j++)
                {
                    var next = top + j;
                    if (longBoard[next] != -1) next = longBoard[next];

                    if (next == longBoard.Length - 1) return step;

                    if (visited.Contains(next)) continue;

                    visited.Add(next);
                    q.Enqueue(next);
                }
            }
        }

        return -1;
    }
}