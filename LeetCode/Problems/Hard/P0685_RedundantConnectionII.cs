namespace LeetCode.Problems.Hard;

/// 冗余连接 II
/// https://leetcode-cn.com/problems/redundant-connection-ii/
public class P0685_RedundantConnectionII
{
    public int[] FindRedundantDirectedConnection(int[][] edges)
    {
        var nodesCount = edges.Length;
        var uf = new UnionFind(nodesCount + 1);
        var parent = new int[nodesCount + 1];
        for (var i = 1; i <= nodesCount; ++i) parent[i] = i;
        var conflict = -1;
        var cycle = -1;
        for (var i = 0; i < nodesCount; ++i)
        {
            var edge = edges[i];
            int node1 = edge[0], node2 = edge[1];
            if (parent[node2] != node2)
            {
                conflict = i;
            }
            else
            {
                parent[node2] = node1;
                if (uf.Find(node1) == uf.Find(node2))
                    cycle = i;
                else
                    uf.Union(node1, node2);
            }
        }

        if (conflict < 0)
        {
            int[] redundant = { edges[cycle][0], edges[cycle][1] };
            return redundant;
        }

        var conflictEdge = edges[conflict];
        if (cycle >= 0)
        {
            int[] redundant = { parent[conflictEdge[1]], conflictEdge[1] };
            return redundant;
        }
        else
        {
            int[] redundant = { conflictEdge[0], conflictEdge[1] };
            return redundant;
        }
    }

    private class UnionFind
    {
        private readonly int[] ancestor;

        public UnionFind(int n)
        {
            ancestor = new int[n];
            for (var i = 0; i < ancestor.Length; i++) ancestor[i] = i;
        }

        public int Find(int a)
        {
            if (ancestor[a] != a) ancestor[a] = Find(ancestor[a]);

            return ancestor[a];
        }

        public void Union(int a, int b)
        {
            ancestor[Find(a)] = Find(b);
        }
    }
}