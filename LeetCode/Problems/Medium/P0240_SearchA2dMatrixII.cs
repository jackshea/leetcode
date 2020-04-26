namespace LeetCode.Problems.Medium
{
    /// 搜索二维矩阵 II
    /// https://leetcode-cn.com/problems/search-a-2d-matrix-ii/
    public class P0240_SearchA2dMatrixII
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0)
            {
                return false;
            }

            int i = matrix.GetLength(0) - 1;
            int j = 0;
            while (j < matrix.GetLength(1) && i >= 0)
            {
                if (target == matrix[i, j])
                {
                    return true;
                }

                if (target < matrix[i, j])
                {
                    i--;
                }
                else
                {
                    j++;
                }
            }

            return false;
        }
    }
}