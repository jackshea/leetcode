namespace LeetCode.Problems.Medium;

/// 冗余连接
/// https://leetcode-cn.com/problems/redundant-connection/
public class P0684_RedundantConnection
{
    public int[] FindRedundantConnection(int[][] edges)
    {
        var unionFind = new UnionFind(edges.Length + 1);
        foreach (var edge in edges)
            if (unionFind.Find(edge[0]) != unionFind.Find(edge[1]))
                unionFind.Union(edge[0], edge[1]);
            else
                return edge;

        return null;
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