using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 收集树上所有苹果的最少时间
/// https://leetcode-cn.com/contest/weekly-contest-188/problems/minimum-time-to-collect-all-apples-in-a-tree/
public class P5406_MinimumTimeToCollectAllApplesInATree
{
    private List<int>[] adj;
    private IList<bool> hasApple;

    public int MinTime(int n, int[][] edges, IList<bool> hasApple)
    {
        this.hasApple = hasApple;
        adj = new List<int>[n];
        for (var i = 0; i < n; i++) adj[i] = new List<int>();

        foreach (var edge in edges)
        {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        var b = false;
        return DFS(0, -1, out b);
    }

    private int DFS(int cur, int pre, out bool hasAppleInSub)
    {
        var ans = 0;
        var curHasApple = hasApple[cur];
        foreach (var next in adj[cur])
        {
            if (next == pre) continue;

            var nextCount = DFS(next, cur, out hasAppleInSub);
            if (hasAppleInSub)
            {
                ans += nextCount + 2;
                curHasApple = true;
            }
        }

        hasAppleInSub = curHasApple;
        return ans;
    }
}