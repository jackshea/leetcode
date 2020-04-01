namespace LeetCode.Problems.Medium
{
    public class P0059_SpiralMatrixII
    {
        /// 螺旋矩阵 II
        /// https://leetcode-cn.com/problems/spiral-matrix-ii/
        public int[][] GenerateMatrix(int n)
        {
            int[] dc = { 1, 0, -1, 0 }; // 行变化量
            int[] dr = { 0, 1, 0, -1 }; // 列变化量
            int start = 0;
            int len = n - 1;
            int v = 1;
            int[][] ans = new int[n][];
            int r = 0;
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                ans[i] = new int[n];
            }
            while (len > 0)
            {
                for (int i = 0; i < dc.Length; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        ans[r][c] = v;
                        v++;
                        r += dr[i];
                        c += dc[i];
                    }
                }

                start++;
                len -= 2;
                r = start;
                c = start;
            }

            if (len == 0)
            {
                ans[r][c] = v;
            }

            return ans;
        }
    }
}