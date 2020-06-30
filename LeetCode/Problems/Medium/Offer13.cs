namespace LeetCode.Problems.Medium
{
    /// 剑指 Offer 13. 机器人的运动范围
    /// https://leetcode-cn.com/problems/ji-qi-ren-de-yun-dong-fan-wei-lcof/
    public class Offer13
    {
        private bool[,] visited;
        private int gridCount;
        private int[] dr = { 1, 0, -1, 0 };
        private int[] dc = { 0, 1, 0, -1 };
        private int m;
        private int n;
        private int k;

        public int MovingCount(int m, int n, int k)
        {
            this.k = k;
            this.n = n;
            this.m = m;
            visited = new bool[m, n];
            DFS(0, 0);
            return gridCount;
        }

        private void DFS(int r, int c)
        {
            if (r < 0 || r >= m || c < 0 || c >= n)
            {
                return;
            }

            if (DigitsCount(r) + DigitsCount(c) > k)
            {
                return;
            }

            if (visited[r, c])
            {
                return;
            }

            visited[r, c] = true;
            gridCount++;
            for (int i = 0; i < dr.Length; i++)
            {
                DFS(r + dr[i], c + dc[i]);
            }
        }

        private int DigitsCount(int x)
        {
            int ans = 0;
            while (x > 0)
            {
                ans += x % 10;
                x /= 10;
            }

            return ans;
        }
    }
}