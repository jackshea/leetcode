namespace LeetCode.Problems.Medium;

/// 翻转矩阵后的得分
/// https://leetcode-cn.com/problems/score-after-flipping-matrix/
public class P0861_ScoreAfterFlippingMatrix
{
    public int MatrixScore(int[][] A)
    {
        var m = A.Length;
        var n = A[0].Length;
        var ans = m * (1 << (n - 1));
        for (var i = 1; i < n; i++)
        {
            var colSum = 0;
            var k = 1 << (n - 1 - i);
            var ones = 0;
            for (var j = 0; j < m; j++)
            {
                var v = A[j][i];
                if (A[j][0] == 0) v = v == 1 ? 0 : 1;

                if (v == 1) ones++;

                colSum += v * k;
            }

            if (ones <= m / 2) colSum = m * k - colSum;

            ans += colSum;
        }

        return ans;
    }
}