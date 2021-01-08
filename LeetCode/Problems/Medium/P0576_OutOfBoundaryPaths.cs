namespace LeetCode.Problems.Medium
{
    /// 出界的路径数
    /// https://leetcode-cn.com/problems/out-of-boundary-paths/
    public class P0576_OutOfBoundaryPaths
    {
        public int FindPaths(int m, int n, int N, int i, int j)
        {
            int[,] pre = new int[m, n];
            int[,] cur = new int[m, n];
            cur[i, j] = 1;
            int[,] nears = { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };
            long ans = 0;

            for (int k = 1; k <= N; k++)
            {
                int[,] temp = pre;
                pre = cur;
                cur = temp;
                for (int a = 0; a < m; a++)
                {
                    for (int b = 0; b < n; b++)
                    {
                        if (a == 0)
                        {
                            ans += pre[a, b];

                        }
                        if (a == m - 1)
                        {
                            ans += pre[a, b];
                        }

                        if (b == 0)
                        {
                            ans += pre[a, b];
                        }

                        if (b == n - 1)
                        {
                            ans += pre[a, b];
                        }

                        ans %= 1_000_000_007;

                        if (k == N)
                        {
                            continue;
                        }

                        cur[a, b] = 0;
                        for (int ni = 0; ni < 4; ni++)
                        {
                            int r = a + nears[ni, 0];
                            int c = b + nears[ni, 1];
                            if (r >= 0 && r < m && c >= 0 && c < n)
                            {
                                cur[a, b] += pre[r, c];
                                cur[a, b] %= 1_000_000_007;
                            }
                        }

                    }
                }
            }

            return (int)ans;
        }
    }
}