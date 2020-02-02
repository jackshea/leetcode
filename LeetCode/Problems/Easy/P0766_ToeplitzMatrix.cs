namespace LeetCode.Problems.Easy
{
    /// 托普利茨矩阵
    /// https://leetcode-cn.com/problems/toeplitz-matrix/
    public class P0766_ToeplitzMatrix
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            for (int i = 1; i < matrix[0].Length; i++)
            {
                for (int j = 1; j < matrix.Length; j++)
                {
                    if (matrix[j][i] != matrix[j - 1][i - 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}