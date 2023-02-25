namespace LeetCode.Problems.Medium;

/// 生命游戏
/// https://leetcode-cn.com/problems/game-of-life/
public class P0289_GameOfLife
{
    public void GameOfLife(int[][] board)
    {
        for (var i = 0; i < board.Length; i++)
        for (var j = 0; j < board[0].Length; j++)
        {
            // 计算周围存活细胞
            var alive = 0;
            for (var r = i - 1; r <= i + 1; r++)
            for (var c = j - 1; c <= j + 1; c++)
            {
                if (r == i && c == j) continue;

                if (r >= 0 && r < board.Length && c >= 0 && c < board[0].Length)
                    if ((board[r][c] & 1) == 1)
                        alive++;
            }

            // 更新当前节点的状态 int倒数第二位存放新状态 0死亡 1存活
            // 1.如果活细胞周围八个位置的活细胞数少于两个，则该位置活细胞死亡；
            var isAlive = (board[i][j] & 1) == 1;
            if (isAlive && alive < 2)
            {
                // do nothing
            }
            else if (isAlive && (alive == 2 || alive == 3)) // 2.如果活细胞周围八个位置有两个或三个活细胞，则该位置活细胞仍然存活；
            {
                board[i][j] |= 2;
            }
            else if (isAlive && alive > 3) // 3.如果活细胞周围八个位置有超过三个活细胞，则该位置活细胞死亡；
            {
                // do nothing
            }
            else if (!isAlive && alive == 3) // 4. 如果死细胞周围正好有三个活细胞，则该位置死细胞复活；
            {
                board[i][j] |= 2;
            }
        }

        // 更新状态。将倒数第二位的值变为倒数第一位
        for (var i = 0; i < board.Length; i++)
        for (var j = 0; j < board[0].Length; j++)
            board[i][j] >>= 1;
    }
}