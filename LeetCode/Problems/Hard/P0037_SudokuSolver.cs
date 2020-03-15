namespace LeetCode.Problems.Hard
{
    /// 解数独
    /// https://leetcode-cn.com/problems/sudoku-solver/
    public class P0037_SudokuSolver
    {
        public void SolveSudoku(char[][] board)
        {
            Solve(board);
        }

        private bool Solve(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == '.')
                    {
                        for (char k = '1'; k <= '9'; k++)
                        {
                            if (isValid(board, i, j, k))
                            {
                                board[i][j] = k;
                                if (Solve(board))
                                {
                                    return true;
                                }
                                else
                                {
                                    board[i][j] = '.';
                                }
                            }
                        }
                        return false;
                    }
                }
            }

            return true;
        }

        private bool isValid(char[][] board, int row, int col, char num)
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