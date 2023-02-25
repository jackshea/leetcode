namespace LeetCode.Problems.Medium;

/// 连通网络的操作次数
/// https://leetcode-cn.com/problems/number-of-operations-to-make-network-connected/
public class P1319_NumberOfOperationsToMakeNetworkConnected
{
    public int MakeConnected(int n, int[][] connections)
    {
        if (connections.Length < n - 1) return -1;

        var uf = new UnionFind(n);
        foreach (var connection in connections) uf.Union(connection[0], connection[1]);

        return uf.SetCount - 1;
    }

    public class UnionFind
    {
        private readonly int[] ancestor;

        public UnionFind(int n)
        {
            ancestor = new int[n];
            for (var i = 0; i < ancestor.Length; i++) ancestor[i] = i;

            SetCount = n;
        }

        public int SetCount { get; private set; }

        public int Find(int x)
        {
            if (ancestor[x] != x) ancestor[x] = Find(ancestor[x]);

            return ancestor[x];
        }

        public void Union(int a, int b)
        {
            var aa = Find(a);
            var ba = Find(b);
            if (aa == ba) return;
            ancestor[aa] = ba;
            SetCount--;
        }
    }
}