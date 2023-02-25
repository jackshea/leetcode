namespace LeetCode.Problems.Medium;

/// 有效的井字游戏
/// https://leetcode-cn.com/problems/valid-tic-tac-toe-state/
public class P0794_ValidTicTacToeState
{
    public bool ValidTicTacToe(string[] board)
    {
        int xCount = 0, oCount = 0;
        foreach (var row in board)
        foreach (var c in row)
            switch (c)
            {
                case 'X':
                    xCount++;
                    break;
                case 'O':
                    oCount++;
                    break;
            }

        if (xCount != oCount && xCount != oCount + 1) return false;
        if (IsWin(board, 'O') && oCount != xCount) return false;
        if (IsWin(board, 'X') && xCount != oCount + 1) return false;

        return true;
    }

    public bool IsWin(string[] board, char player)
    {
        for (var i = 0; i < 3; i++)
        {
            // 行
            if (board[i][0] == player && board[i][1] == player && board[i][2] == player) return true;
            // 列
            if (board[0][i] == player && board[1][i] == player && board[2][i] == player) return true;
        }

        // 对角
        if (board[0][0] == player && board[1][1] == player && board[2][2] == player) return true;

        if (board[0][2] == player && board[1][1] == player && board[2][0] == player) return true;

        return false;
    }
}