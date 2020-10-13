namespace LeetCode.Problems.Medium
{
    /// 甲板上的战舰
    /// https://leetcode-cn.com/problems/battleships-in-a-board/
    public class P0419_BattleshipsInABoard
    {
        public int CountBattleships(char[][] board)
        {
            int ans = 0;
            if (board == null || board.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == 'X' && (i == 0 || board[i - 1][j] == '.') && (j == 0 || board[i][j - 1] == '.'))
                    {
                        ans++;
                    }
                }
            }

            return ans;
        }
    }
}