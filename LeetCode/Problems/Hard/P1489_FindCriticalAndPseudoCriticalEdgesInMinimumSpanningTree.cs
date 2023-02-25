using System.Collections.Generic;

namespace LeetCode.Problems.Hard;

/// 找到最小生成树里的关键边和伪关键边
/// https://leetcode-cn.com/problems/find-critical-and-pseudo-critical-edges-in-minimum-spanning-tree/
public class P1489_FindCriticalAndPseudoCriticalEdgesInMinimumSpanningTree
{
    public IList<IList<int>> FindCriticalAndPseudoCriticalEdges(int n, int[][] edges)
    {
        var edgeList = new List<Edge>();
        for (var i = 0; i < edges.Length; i++)
        {
            var edge = edges[i];
            edgeList.Add(new Edge { P1 = edge[0], P2 = edge[1], Weight = edge[2], Index = i });
        }

        edgeList.Sort((a, b) => a.Weight.CompareTo(b.Weight));
        var uf = new UnionFind(n);
        var minCost = 0;

        foreach (var edge in edgeList)
        {
            if (uf.Union(edge.P1, edge.P2)) minCost += edge.Weight;

            if (uf.SetCount == 1) break;
        }

        var keyEdges = new List<int>();
        var notKeyEdges = new List<int>();
        var ans = new List<IList<int>> { keyEdges, notKeyEdges };
        for (var i = 0; i < edgeList.Count; i++)
        {
            uf.Reset();
            var cost = 0;
            for (var j = 0; j < edgeList.Count; j++)
            {
                var edge = edgeList[j];
                if (i != j && uf.Union(edge.P1, edge.P2)) cost += edge.Weight;
            }

            if ((uf.SetCount == 1 && cost > minCost) || uf.SetCount != 1)
            {
                keyEdges.Add(edgeList[i].Index);
                continue;
            }

            uf.Reset();
            uf.Union(edgeList[i].P1, edgeList[i].P2);
            cost = edgeList[i].Weight;
            for (var j = 0; j < edgeList.Count; j++)
            {
                var edge = edgeList[j];
                if (i != j && uf.Union(edge.P1, edge.P2)) cost += edge.Weight;
            }

            if (cost == minCost) notKeyEdges.Add(edgeList[i].Index);
        }

        return ans;
    }

    public class Edge
    {
        public int Index;
        public int P1;
        public int P2;
        public int Weight;
    }

    public class UnionFind
    {
        private readonly int[] ancestor;

        public UnionFind(int n)
        {
            ancestor = new int[n];
            Reset();
        }

        public int SetCount { get; private set; }

        public int Find(int x)
        {
            if (x != ancestor[x]) ancestor[x] = Find(ancestor[x]);

            return ancestor[x];
        }

        public bool Union(int a, int b)
        {
            var aa = Find(a);
            var ba = Find(b);
            if (aa == ba) return false;
            ancestor[aa] = ba;
            SetCount--;
            return true;
        }

        public void Reset()
        {
            SetCount = ancestor.Length;
            for (var i = 0; i < ancestor.Length; i++) ancestor[i] = i;
        }
    }
}