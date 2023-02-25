namespace LeetCode.Problems.Medium;

public class MST1604
{
    /// 井字游戏
    /// https://leetcode-cn.com/problems/tic-tac-toe-lcci/
    public string Tictactoe(string[] board)
    {
        var isWin = true;
        // 行
        foreach (var row in board)
        {
            isWin = true;
            for (var i = 1; i < row.Length; i++)
                if (row[i] == ' ' || row[i] != row[0])
                {
                    isWin = false;
                    break;
                }

            if (isWin) return row[0].ToString();
        }

        // 列
        for (var i = 0; i < board[0].Length; i++)
        {
            isWin = true;
            for (var j = 1; j < board.Length; j++)
                if (board[j][i] == ' ' || board[j][i] != board[0][i])
                {
                    isWin = false;
                    break;
                }

            if (isWin) return board[0][i].ToString();
        }

        // 斜线1
        isWin = true;
        for (var i = 0; i < board.Length; i++)
            if (board[i][i] == ' ' || board[i][i] != board[0][0])
            {
                isWin = false;
                break;
            }

        if (isWin) return board[0][0].ToString();

        // 斜线2
        isWin = true;
        for (var i = 0; i < board.Length; i++)
            if (board[board.Length - 1 - i][i] == ' ' || board[board.Length - 1 - i][i] != board[board.Length - 1][0])
            {
                isWin = false;
                break;
            }

        if (isWin) return board[board.Length - 1][0].ToString();

        for (var i = 0; i < board.Length; i++)
            foreach (var c in board[i])
                if (c == ' ')
                    return "Pending";

        return "Draw";
    }
}