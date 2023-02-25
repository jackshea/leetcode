namespace LeetCode.Problems.Medium;

/// 矩阵区域和
/// https://leetcode-cn.com/problems/matrix-block-sum/
public class P1314_MatrixBlockSum
{
    private int m;
    private int n;
    private int[,] sum;

    public int[][] MatrixBlockSum(int[][] mat, int k)
    {
        m = mat.Length;
        n = mat[0].Length;
        sum = new int[m + 1, n + 1];
        for (var i = 1; i <= m; i++)
        for (var j = 1; j <= n; j++)
            sum[i, j] = sum[i - 1, j] + sum[i, j - 1] - sum[i - 1, j - 1] + mat[i - 1][j - 1];

        var ans = new int[m][];
        for (var i = 0; i < m; i++)
        {
            ans[i] = new int[n];
            for (var j = 0; j < n; j++)
                ans[i][j] = Get(i + k + 1, j + k + 1) - Get(i - k, j + k + 1) - Get(i + k + 1, j - k) +
                            Get(i - k, j - k);
        }

        return ans;
    }

    public int Get(int x, int y)
    {
        x = x < 0 ? 0 : x > m ? m : x;
        y = y < 0 ? 0 : y > n ? n : y;
        return sum[x, y];
    }
}