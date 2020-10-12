using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Problems
{
    /// 太平洋大西洋水流问题
    /// https://leetcode-cn.com/problems/pacific-atlantic-water-flow/
    public class P0417_PacificAtlanticWaterFlow
    {
        // 用于标记能到达的海洋，太平洋为1，大西洋为2，两边都能到达为3
        private int[,] mark;

        public IList<IList<int>> PacificAtlantic(int[][] matrix)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            if (matrix == null || matrix.Length == 0)
            {
                return ans;
            }

            mark = new int[matrix.Length, matrix[0].Length];

            // 从四条边界开始DFS
            for (int i = 0; i < matrix.Length; i++)
            {
                DFS(matrix, 0, i, 0, 1);
            }

            for (int i = 0; i < matrix[0].Length; i++)
            {
                DFS(matrix, 0, 0, i, 1);
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                DFS(matrix, 0, i, matrix[0].Length - 1, 2);
            }

            for (int i = 0; i < matrix[0].Length; i++)
            {
                DFS(matrix, 0, matrix.Length - 1, i, 2);
            }

            // 从 mark 中得到答案
            for (int i = 0; i < mark.GetLength(0); i++)
            {
                for (int j = 0; j < mark.GetLength(1); j++)
                {
                    // 代表同时被太平洋和大西洋标记
                    if (mark[i, j] == 3)
                    {
                        ans.Add(new List<int> { i, j });
                    }
                }
            }

            return ans;
        }

        /// preH 上一节点的高度，初始海洋为0; r、c为当的行列坐标;sea 标记 太平洋为1，大西洋为2
        public void DFS(int[][] matrix, int preH, int r, int c, int sea)
        {
            if (r < 0 || r >= matrix.Length || c < 0 || c >= matrix[0].Length)
            {
                return;
            }

            if (mark[r, c] >= sea)
            {
                return;
            }

            var h = matrix[r][c];
            if (h < preH)
            {
                return;
            }

            mark[r, c] += sea;

            DFS(matrix, h, r + 1, c, sea);
            DFS(matrix, h, r - 1, c, sea);
            DFS(matrix, h, r, c + 1, sea);
            DFS(matrix, h, r, c - 1, sea);
        }
    }
}