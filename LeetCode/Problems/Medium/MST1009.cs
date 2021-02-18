namespace LeetCode.Problems.Medium
{
    /// 排序矩阵查找
    /// https://leetcode-cn.com/problems/sorted-matrix-search-lcci/
    public class MST1009
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0)
            {
                return false;
            }

            int r = 0, c = matrix.GetLength(1) - 1;
            while (c >= 0 && r < matrix.GetLength(0))
            {
                if (target == matrix[r, c])
                {
                    return true;
                }
                else if (target > matrix[r, c])
                {
                    r++;
                }
                else
                {
                    c--;
                }
            }

            return false;
        }
    }
}