namespace LeetCode.Problems.Medium
{
    /// 被围绕的区域
    /// https://leetcode-cn.com/problems/surrounded-regions/
    public class P0130_SurroundedRegions
    {
        private bool[,] mark;
        private char[][] board;
        private int[] dr = { 1, 0, -1, 0 };
        private int[] dc = { 0, 1, 0, -1 };

        public void Solve(char[][] board)
        {
            this.board = board;
            if (board.Length == 0)
            {
                return;
            }

            mark = new bool[board.Length, board[0].Length];
            for (int i = 0; i < board.Length; i++)
            {
                DFS(i, 0);
                DFS(i, board[0].Length - 1);
            }

            for (int i = 1; i < board[0].Length - 1; i++)
            {
                DFS(0, i);
                DFS(board.Length - 1, i);
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == 'O' && mark[i, j] == false)
                    {
                        board[i][j] = 'X';
                    }
                }
            }
        }

        private void DFS(int r, int c)
        {
            if (r < 0 || r >= board.Length || c < 0 || c >= board[0].Length)
            {
                return;
            }

            if (mark[r, c] || board[r][c] == 'X')
            {
                return;
            }

            mark[r, c] = true;

            for (int i = 0; i < dr.Length; i++)
            {
                DFS(r + dr[i], c + dc[i]);
            }
        }
    }
}