using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 蛇梯棋
    /// https://leetcode-cn.com/problems/snakes-and-ladders/
    public class P0909_SnakesAndLadders
    {
        public int SnakesAndLadders(int[][] board)
        {
            int m = board.Length;
            int n = board[0].Length;
            if (m * n <= 7)
            {
                return 1;
            }

            int[] longBoard = new int[m * n + 1];
            int lIndex = 1;
            bool dir = true;
            for (int i = m - 1; i >= 0; i--)
            {
                if (dir)
                {
                    for (int j = 0; j < n; j++)
                    {
                        longBoard[lIndex++] = board[i][j];
                    }
                }
                else
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        longBoard[lIndex++] = board[i][j];
                    }
                }

                dir = !dir;
            }

            int step = 0;
            Queue<int> q = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();
            q.Enqueue(1);
            visited.Add(1);
            while (q.Count > 0)
            {
                step++;
                int qCount = q.Count;
                for (int i = 0; i < qCount; i++)
                {
                    var top = q.Dequeue();
                    if (top >= longBoard.Length - 6)
                    {
                        return step;
                    }

                    for (int j = 1; j <= 6; j++)
                    {
                        int next = top + j;
                        if (longBoard[next] != -1)
                        {
                            next = longBoard[next];
                        }

                        if (next == longBoard.Length - 1)
                        {
                            return step;
                        }

                        if (visited.Contains(next))
                        {
                            continue;
                        }

                        visited.Add(next);
                        q.Enqueue(next);
                    }
                }
            }

            return -1;
        }
    }
}