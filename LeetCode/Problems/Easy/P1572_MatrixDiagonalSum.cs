namespace LeetCode.Problems.Easy
{
    /// 矩阵对角线元素的和
    /// https://leetcode-cn.com/problems/matrix-diagonal-sum/
    public class P1572_MatrixDiagonalSum
    {
        public int DiagonalSum(int[][] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                sum += mat[i][i] + mat[mat.Length - 1 - i][i];
            }
            if (mat.Length % 2 != 0)
            {
                sum -= mat[mat.Length / 2][mat.Length / 2];
            }

            return sum;
        }
    }
}