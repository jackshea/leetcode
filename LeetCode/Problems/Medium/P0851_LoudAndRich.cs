using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 喧闹和富有
/// https://leetcode-cn.com/problems/loud-and-rich/
public class P0851_LoudAndRich
{
    private int[] ans;
    private List<int>[] graph;
    private int[] quiet;

    public int[] LoudAndRich(int[][] richer, int[] quiet)
    {
        this.quiet = quiet;
        var n = quiet.Length;
        ans = new int[n];
        graph = new List<int>[n];
        for (var i = 0; i < n; i++) graph[i] = new List<int>();

        foreach (var r in richer) graph[r[1]].Add(r[0]);

        Array.Fill(ans, -1);

        for (var i = 0; i < n; i++) DFS(i);

        return ans;
    }

    public int DFS(int node)
    {
        if (ans[node] != -1) return ans[node];

        ans[node] = node;
        foreach (var child in graph[node])
        {
            var cand = DFS(child);
            if (quiet[cand] < quiet[ans[node]]) ans[node] = cand;
        }

        return ans[node];
    }
}