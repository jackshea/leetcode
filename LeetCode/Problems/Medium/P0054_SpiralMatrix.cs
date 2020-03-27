using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 螺旋矩阵
    /// https://leetcode-cn.com/problems/spiral-matrix/
    public class P0054_SpiralMatrix
    {
        private int m; // 行
        private int n; // 列

        private int[] dm = { 0, 1, 0, -1 };
        private int[] dn = { 1, 0, -1, 0 };

        private int[][] matrix;
        private bool[,] visited;

        private IList<int> ans;

        public IList<int> SpiralOrder(int[][] matrix)
        {
            ans = new List<int>();
            if (matrix.Length == 0)
            {
                return ans;
            }
            this.matrix = matrix;
            m = matrix.Length;
            n = matrix[0].Length;
            visited = new bool[m, n];
            DFS(new[] { 0, -1 }, 0, m * n);
            return ans;
        }

        /// startPos[0] 行索引，startPos[1] 列索引
        private void DFS(int[] startPos, int dir, int step)
        {
            if (step <= 0)
            {
                return;
            }

            startPos[0] += dm[dir];
            startPos[1] += dn[dir];
            while (startPos[0] >= 0 && startPos[0] < m && startPos[1] >= 0 && startPos[1] < n && !visited[startPos[0], startPos[1]])
            {
                ans.Add(matrix[startPos[0]][startPos[1]]);
                visited[startPos[0], startPos[1]] = true;
                step--;
                startPos[0] += dm[dir];
                startPos[1] += dn[dir];
            }
            startPos[0] -= dm[dir];
            startPos[1] -= dn[dir];
            DFS(startPos, (dir + 1) % dn.Length, step);
        }
    }
}