namespace LeetCode.Problems
{
    /// 找出井字棋的获胜者
    /// https://leetcode-cn.com/problems/find-winner-on-a-tic-tac-toe-game/
    public class P1275_FindWinnerOnATicTacToeGame
    {
        public string Tictactoe(int[][] moves)
        {
            char[,] board = new char[3, 3];
            int turn = 0; // 0:A X  1:B O
            for (var i = 0; i < moves.Length; i++)
            {
                var move = moves[i];
                int r = move[0];
                int c = move[1];
                var piece = turn == 0 ? 'X' : 'O';
                board[r, c] = piece;

                // 验证
                // 行
                var checkRow = board[r, 0] == piece && board[r, 1] == piece && board[r, 2] == piece;
                // 列
                var checkCol = board[0, c] == piece && board[1, c] == piece && board[2, c] == piece;
                // 斜线
                var checkBias1 = false;
                var checkBias2 = false;
                if (r == c)
                {
                    checkBias1 = board[0, 0] == piece && board[1, 1] == piece && board[2, 2] == piece;
                }

                if (r == 2 - c)
                {
                    checkBias2 = board[0, 2] == piece && board[1, 1] == piece && board[2, 0] == piece;
                }

                if (checkRow || checkCol || checkBias1 || checkBias2)
                {
                    return turn == 0 ? "A" : "B";
                }
                else if (i >= 8)
                {
                    return "Draw";
                }


                turn++;
                turn %= 2;
            }

            return "Pending";
        }
    }
}