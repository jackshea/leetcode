namespace LeetCode.Problems.Hard
{
    /// 元素和为目标值的子矩阵数量
    /// https://leetcode-cn.com/problems/number-of-submatrices-that-sum-to-target/
    public class P1074_NumberOfSubmatricesThatSumToTarget
    {
        public int NumSubmatrixSumTarget(int[][] matrix, int target)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int[,] preSum = new int[m + 1, n + 1];
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    preSum[i, j] = matrix[i - 1][j - 1] + preSum[i - 1, j] - preSum[i, j - 1] + preSum[i - 1, j - 1];
                }
            }

            int ans = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = i; k <= m; k++)
                    {
                        for (int l = j; l <= n; l++)
                        {
                            if (preSum[k, l] - preSum[i - 1, l] - preSum[k, j - 1] + preSum[i - 1, j - 1] == target)
                            {
                                ans++;
                            }
                        }
                    }
                }
            }

            return ans;
        }
    }
}