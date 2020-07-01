namespace LeetCode.Problems.Easy
{
    /// 统计有序矩阵中的负数
    /// https://leetcode-cn.com/problems/count-negative-numbers-in-a-sorted-matrix/
    public class P1351_CountNegativeNumbersInASortedMatrix
    {
        public int CountNegatives(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int maxC = grid[0].Length - 1;
            int c = maxC;
            int ans = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                while (grid[i][c] < 0)
                {
                    c--;
                    if (c < 0)
                    {
                        ans += (grid.Length - i) * grid[0].Length;
                        return ans;
                    }
                }

                ans += maxC - c;
            }

            return ans;
        }
    }
}