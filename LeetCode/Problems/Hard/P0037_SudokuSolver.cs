namespace LeetCode.Problems.Hard
{
    /// 解数独
    /// https://leetcode-cn.com/problems/sudoku-solver/
    public class P0037_SudokuSolver
    {
        private char[][] board;

        public void SolveSudoku(char[][] board)
        {
            this.board = board;
            Solve(0, 0);
        }

        private bool Solve(int r, int c)
        {
            if (r >= board.Length)
            {
                return true;
            }

            if (c >= board[0].Length)
            {
                return Solve(r + 1, 0);
            }

            if (board[r][c] == '.')
            {
                for (char k = '1'; k <= '9'; k++)
                {
                    if (isValid(r, c, k))
                    {
                        board[r][c] = k;
                        if (Solve(r, c + 1))
                        {
                            return true;
                        }
                        board[r][c] = '.';
                    }
                }
                return false;
            }
            else
            {
                return Solve(r, c + 1);
            }
        }

        private bool isValid(int row, int col, char num)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (i == row && board[i][j] == num)
                    {
                        return false;
                    }
                    if (j == col && board[i][j] == num)
                    {
                        return false;
                    }

                    if (i / 3 == row / 3 && j / 3 == col / 3 && board[i][j] == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}