namespace LeetCode.Problems.Hard
{
    /// 情侣牵手
    /// https://leetcode-cn.com/problems/couples-holding-hands/
    public class P0765_CouplesHoldingHands
    {
        public int MinSwapsCouples(int[] row)
        {
            var n = row.Length;
            var uf = new UnionFind(n);
            for (int i = 0; i < n; i += 2)
            {
                uf.Union(row[i], row[i + 1]);
                uf.Union(row[i], Partner(row[i]));
                uf.Union(row[i + 1], Partner(row[i + 1]));
            }

            return n / 2 - uf.SetCount;
        }

        private int Partner(int n)
        {
            return n % 2 == 0 ? n + 1 : n - 1;
        }

        public class UnionFind
        {
            public int SetCount { get; private set; }
            private int[] ancestor;

            public UnionFind(int n)
            {
                ancestor = new int[n];
                for (int i = 0; i < n; i++)
                {
                    ancestor[i] = i;
                }

                SetCount = n;
            }

            public int Find(int x)
            {
                if (ancestor[x] != x)
                {
                    ancestor[x] = Find(ancestor[x]);
                }

                return ancestor[x];
            }

            public void Union(int a, int b)
            {
                var aa = Find(a);
                var ba = Find(b);
                if (aa == ba)
                {
                    return;
                }

                ancestor[aa] = ba;
                SetCount--;
            }
        }
    }
}