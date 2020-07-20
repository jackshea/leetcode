namespace LeetCode.Problems.Easy
{
    /// 剑指 Offer 04. 二维数组中的查找
    /// https://leetcode-cn.com/problems/er-wei-shu-zu-zhong-de-cha-zhao-lcof/
    public class Offer04
    {
        public bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            {
                return false;
            }
            int r = matrix.Length - 1, c = 0;
            while (r >= 0 && c < matrix[0].Length)
            {
                if (matrix[r][c] == target)
                {
                    return true;
                }
                else if (matrix[r][c] < target)
                {
                    c++;
                }
                else
                {
                    r--;
                }
            }

            return false;
        }
    }
}