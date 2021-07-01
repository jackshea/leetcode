using System;

namespace LeetCode.Problems.Medium
{
    /// 图像重叠
    /// https://leetcode-cn.com/problems/image-overlap/
    public class P0835_ImageOverlap
    {
        public int LargestOverlap(int[][] img1, int[][] img2)
        {
            var n = img1.Length;
            int[,] delta = new int[2 * n + 1, 2 * n + 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (img1[i][j] == 1)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            for (int l = 0; l < n; l++)
                            {
                                if (img2[k][l] == 1)
                                {
                                    delta[i - k + n, j - l + n]++;
                                }
                            }
                        }
                    }
                }
            }

            int ans = 0;
            for (int i = 0; i < delta.GetLength(0); i++)
            {
                for (int j = 0; j < delta.GetLength(1); j++)
                {
                    ans = Math.Max(ans, delta[i, j]);
                }
            }

            return ans;
        }
    }
}