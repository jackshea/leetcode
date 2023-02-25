namespace LeetCode.Problems.Hard;

/// 元素和为目标值的子矩阵数量
/// https://leetcode-cn.com/problems/number-of-submatrices-that-sum-to-target/
public class P1074_NumberOfSubmatricesThatSumToTarget
{
    public int NumSubmatrixSumTarget(int[][] matrix, int target)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var preSum = new int[m + 1, n + 1];
        for (var i = 1; i <= m; i++)
        for (var j = 1; j <= n; j++)
            preSum[i, j] = matrix[i - 1][j - 1] + preSum[i - 1, j] - preSum[i, j - 1] + preSum[i - 1, j - 1];

        var ans = 0;
        for (var i = 1; i <= m; i++)
        for (var j = 1; j <= n; j++)
        for (var k = i; k <= m; k++)
        for (var l = j; l <= n; l++)
            if (preSum[k, l] - preSum[i - 1, l] - preSum[k, j - 1] + preSum[i - 1, j - 1] == target)
                ans++;

        return ans;
    }
}