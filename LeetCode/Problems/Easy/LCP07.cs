using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 传递信息
/// https://leetcode-cn.com/problems/chuan-di-xin-xi/
public class LCP07
{
    public int NumWays(int n, int[][] relation, int k)
    {
        var adj = new List<int>[n];
        for (var i = 0; i < n; i++) adj[i] = new List<int>();
        foreach (var r in relation) adj[r[0]].Add(r[1]);

        return DFS(adj, n, k, 0);
    }

    private int DFS(List<int>[] adj, int n, int k, int cur)
    {
        if (k <= 0) return cur == n - 1 ? 1 : 0;

        var ans = 0;
        foreach (var a in adj[cur]) ans += DFS(adj, n, k - 1, a);

        return ans;
    }
}