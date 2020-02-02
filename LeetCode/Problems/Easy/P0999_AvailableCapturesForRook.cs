namespace LeetCode.Problems
{
    /// 车的可用捕获量
    /// https://leetcode-cn.com/problems/available-captures-for-rook/
    public class P0999_AvailableCapturesForRook
    {
        public int NumRookCaptures(char[][] board)
        {
            int[] rPos = null;
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == 'R')
                    {
                        rPos = new[] { i, j };
                    }
                }
            }

            int ans = 0;
            var dir = new int[][] { new[] { 1, 0 }, new[] { -1, 0 }, new[] { 0, 1 }, new[] { 0, -1 }, };
            for (int i = 0; i < dir.Length; i++)
            {
                var pos = new[] { rPos[0], rPos[1] };
                while (true)
                {
                    pos[0] += dir[i][0];
                    pos[1] += dir[i][1];
                    if (pos[0] >= 0 && pos[0] < board.Length && pos[1] >= 0 && pos[1] < board.Length)
                    {
                        var v = board[pos[0]][pos[1]];
                        if (v == 'p')
                        {
                            ans++;
                            break;
                        }
                        else if (v == 'B')
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return ans;
        }
    }
}