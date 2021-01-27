namespace LeetCode.Problems.Hard
{
    /// 保证图可完全遍历
    /// https://leetcode-cn.com/problems/remove-max-number-of-edges-to-keep-graph-fully-traversable/
    public class P1579_RemoveMaxNumberOfEdgesToKeepGraphFullyTraversable
    {
        public int MaxNumEdgesToRemove(int n, int[][] edges)
        {
            UnionFind[] ufs = { new UnionFind(n + 1), new UnionFind(n + 1) };
            int ans = 0;
            foreach (var edge in edges)
            {
                if (edge[0] != 3)
                {
                    continue;
                }

                if (ufs[0].Union(edge[1], edge[2]))
                {
                    ufs[1].Union(edge[1], edge[2]);
                }
                else
                {
                    ans++;
                }
            }

            foreach (var edge in edges)
            {
                if (edge[0] == 3)
                {
                    continue;
                }

                if (!ufs[edge[0] - 1].Union(edge[1], edge[2]))
                {
                    ans++;
                }
            }

            return ufs[0].SetCount == 2 && ufs[1].SetCount == 2 ? ans : -1;
        }

        public class UnionFind
        {
            public int SetCount { get; private set; }
            private int[] ancestor;

            public UnionFind(int n)
            {
                ancestor = new int[n];
                SetCount = n;
                for (int i = 0; i < n; i++)
                {
                    ancestor[i] = i;
                }
            }

            public int Find(int x)
            {
                if (ancestor[x] != x)
                {
                    ancestor[x] = Find(ancestor[x]);
                }

                return ancestor[x];
            }

            public bool Union(int a, int b)
            {
                var aa = Find(a);
                var ba = Find(b);
                if (aa == ba)
                {
                    return false;
                }

                SetCount--;
                ancestor[aa] = ba;
                return true;
            }
        }
    }
}