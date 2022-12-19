namespace LeetCode.Problems.Easy
{
    /// 寻找图中是否存在路径
    /// https://leetcode.cn/problems/find-if-path-exists-in-graph/
    public class P1971_FindIfPathExistsInGraph
    {
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            var uf = new UnionFind(n);
            for (int i = 0; i < edges.Length; i++)
            {
                uf.Union(edges[i][0],edges[i][1]);
            }

            return uf.Find(source) == uf.Find(destination);
        }

        class UnionFind
        {
            private int[] ancestor;

            public UnionFind(int n)
            {
                ancestor = new int[n];
                for (int i = 0; i < ancestor.Length; i++)
                {
                    ancestor[i] = i;
                }
            }

            public int Find(int a)
            {
                if (ancestor[a] != a)
                {
                    ancestor[a] = Find(ancestor[a]);
                }

                return ancestor[a];
            }

            public void Union(int a, int b)
            {
                ancestor[Find(a)] = Find(b);
            }
        }
    }
}