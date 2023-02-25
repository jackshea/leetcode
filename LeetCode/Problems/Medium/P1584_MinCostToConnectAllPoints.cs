using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 连接所有点的最小费用
/// https://leetcode-cn.com/problems/min-cost-to-connect-all-points/
public class P1584_MinCostToConnectAllPoints
{
    /// Kruskal 算法
    public int MinCostConnectPoints(int[][] points)
    {
        var n = points.Length;
        var uf = new UnionFind(n);
        var edges = new List<Edge>(n * (n - 1) / 2);
        for (var i = 0; i < n; i++)
        for (var j = i + 1; j < n; j++)
            edges.Add(new Edge { P1 = i, P2 = j, Length = Dist(points, i, j) });

        edges.Sort((a, b) => a.Length.CompareTo(b.Length));
        var ans = 0;
        var joinedCnt = 1;
        foreach (var edge in edges)
        {
            if (uf.Find(edge.P1) != uf.Find(edge.P2))
            {
                uf.Union(edge.P1, edge.P2);
                ans += edge.Length;
                joinedCnt++;
            }

            if (joinedCnt == n) break;
        }

        return ans;
    }

    private int Dist(int[][] points, int p1, int p2)
    {
        return Math.Abs(points[p1][0] - points[p2][0]) + Math.Abs(points[p1][1] - points[p2][1]);
    }

    private struct Edge
    {
        public int P1;
        public int P2;
        public int Length;
    }

    private class UnionFind
    {
        private readonly int[] ancestors;

        public UnionFind(int n)
        {
            ancestors = new int[n];
            for (var i = 0; i < n; i++) ancestors[i] = i;
        }

        public int Find(int x)
        {
            if (x != ancestors[x]) ancestors[x] = Find(ancestors[x]);

            return ancestors[x];
        }

        public void Union(int a, int b)
        {
            ancestors[Find(a)] = Find(b);
        }
    }
}