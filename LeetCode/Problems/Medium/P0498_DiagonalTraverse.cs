namespace LeetCode.Problems.Medium
{
    /// 对角线遍历
    /// https://leetcode-cn.com/problems/diagonal-traverse/
    public class P0498_DiagonalTraverse
    {
        public int[] FindDiagonalOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                return new int[0];
            }
            int[] ans = new int[matrix.Length * matrix[0].Length];
            int r = 0;
            int c = 0;
            for (int i = 0; i < ans.Length; i++)
            {
                ans[i] = matrix[r][c];
                if ((r + c) % 2 == 0)
                {
                    if (c >= matrix[0].Length - 1)
                    {
                        r++;
                    }
                    else if (r <= 0)
                    {
                        c++;
                    }
                    else
                    {
                        c++;
                        r--;
                    }
                }
                else
                {
                    if (r >= matrix.Length - 1)
                    {
                        c++;
                    }
                    else if (c <= 0)
                    {
                        r++;
                    }
                    else
                    {
                        c--;
                        r++;
                    }
                }
            }

            return ans;
        }
    }
}