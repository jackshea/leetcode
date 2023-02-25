namespace LeetCode.Problems.Medium;

/// 由斜杠划分区域
/// https://leetcode-cn.com/problems/regions-cut-by-slashes/
public class P0959_RegionsCutBySlashes
{
    /// 0
    /// 2   3
    /// 1
    public int RegionsBySlashes(string[] grid)
    {
        var length = grid[0].Length;
        var uf = new UnionFind(grid.Length * length * 4);
        var index = 0;
        for (var i = 0; i < grid.Length; i++)
        for (var j = 0; j < length; j++)
        {
            var c = grid[i][j];
            var pos = index * 4;
            if (c == '\\')
            {
                uf.Union(pos, pos + 3);
                uf.Union(pos + 1, pos + 2);
            }
            else if (c == '/')
            {
                uf.Union(pos, pos + 2);
                uf.Union(pos + 1, pos + 3);
            }
            else
            {
                uf.Union(pos, pos + 1);
                uf.Union(pos + 1, pos + 2);
                uf.Union(pos + 2, pos + 3);
            }

            if (i > 0) uf.Union(pos + 2, ((i - 1) * length + j) * 4 + 3);

            if (j > 0) uf.Union(pos, (i * length + j - 1) * 4 + 1);

            index++;
        }

        return uf.SetCount;
    }

    public class UnionFind
    {
        private readonly int[] ancestor;

        public UnionFind(int n)
        {
            SetCount = n;
            ancestor = new int[n];
            for (var i = 0; i < n; i++) ancestor[i] = i;
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

            SetCount--;
            ancestor[aa] = ba;
        }
    }
}