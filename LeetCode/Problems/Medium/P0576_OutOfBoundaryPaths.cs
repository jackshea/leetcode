namespace LeetCode.Problems.Medium;

/// 出界的路径数
/// https://leetcode-cn.com/problems/out-of-boundary-paths/
public class P0576_OutOfBoundaryPaths
{
    public int FindPaths(int m, int n, int N, int i, int j)
    {
        var pre = new int[m, n];
        var cur = new int[m, n];
        cur[i, j] = 1;
        int[,] nears = { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };
        long ans = 0;

        for (var k = 1; k <= N; k++)
        {
            var temp = pre;
            pre = cur;
            cur = temp;
            for (var a = 0; a < m; a++)
            for (var b = 0; b < n; b++)
            {
                if (a == 0) ans += pre[a, b];
                if (a == m - 1) ans += pre[a, b];

                if (b == 0) ans += pre[a, b];

                if (b == n - 1) ans += pre[a, b];

                ans %= 1_000_000_007;

                if (k == N) continue;

                cur[a, b] = 0;
                for (var ni = 0; ni < 4; ni++)
                {
                    var r = a + nears[ni, 0];
                    var c = b + nears[ni, 1];
                    if (r >= 0 && r < m && c >= 0 && c < n)
                    {
                        cur[a, b] += pre[r, c];
                        cur[a, b] %= 1_000_000_007;
                    }
                }
            }
        }

        return (int)ans;
    }
}