namespace LeetCode.Problems.Medium
{
    /// “马”在棋盘上的概率
    /// https://leetcode-cn.com/problems/knight-probability-in-chessboard/
    public class P0688_KnightProbabilityInChessboard
    {
        public double KnightProbability(int N, int K, int r, int c)
        {
            double[,] dp = new double[N, N];
            int[] dr = { -2, -2, -1, -1, 1, 1, 2, 2 };
            int[] dc = { -1, 1, -2, 2, -2, 2, -1, 1 };
            dp[r, c] = 1;
            for (; K > 0; K--)
            {
                double[,] dp2 = new double[N, N];
                for (int rr = 0; rr < N; rr++)
                {
                    for (int cc = 0; cc < N; cc++)
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            int nr = rr + dr[k];
                            int nc = cc + dc[k];
                            if (0 <= nr && nr < N && 0 <= nc && nc < N)
                            {
                                dp2[nr, nc] += dp[rr, cc] / 8.0;
                            }
                        }
                    }
                }

                dp = dp2;
            }

            double ans = 0.0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    ans += dp[i, j];
                }
            }

            return ans;
        }
    }
}