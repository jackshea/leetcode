namespace LeetCode.Problems.Medium
{
    /// 翻转矩阵后的得分
    /// https://leetcode-cn.com/problems/score-after-flipping-matrix/
    public class P0861_ScoreAfterFlippingMatrix
    {
        public int MatrixScore(int[][] A)
        {
            var m = A.Length;
            var n = A[0].Length;
            int ans = m * (1 << (n - 1));
            for (int i = 1; i < n; i++)
            {
                int colSum = 0;
                int k = 1 << (n - 1 - i);
                int ones = 0;
                for (int j = 0; j < m; j++)
                {
                    int v = A[j][i];
                    if (A[j][0] == 0)
                    {
                        v = v == 1 ? 0 : 1;
                    }

                    if (v == 1)
                    {
                        ones++;
                    }

                    colSum += v * k;
                }

                if (ones <= m / 2)
                {
                    colSum = m * k - colSum;
                }

                ans += colSum;
            }

            return ans;
        }
    }
}