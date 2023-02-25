using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 移除最多的同行或同列石头
/// https://leetcode-cn.com/problems/most-stones-removed-with-same-row-or-column/
public class P0947_MostStonesRemovedWithSameRowOrColumn
{
    public int RemoveStones(int[][] stones)
    {
        var unionFind = new UnionFind();
        foreach (var stone in stones) unionFind.Union(stone[0] + 10001, stone[1]);

        return stones.Length - unionFind.Count;
    }

    public class UnionFind
    {
        private readonly Dictionary<int, int> ancestors;

        public UnionFind()
        {
            ancestors = new Dictionary<int, int>();
        }

        public int Count { get; private set; }

        public int Find(int x)
        {
            if (!ancestors.ContainsKey(x))
            {
                ancestors[x] = x;
                Count++;
                return x;
            }

            if (x != ancestors[x]) ancestors[x] = Find(ancestors[x]);

            return ancestors[x];
        }

        public void Union(int x, int y)
        {
            var xAncestor = Find(x);
            var yAncestor = Find(y);
            if (xAncestor == yAncestor) return;
            ancestors[xAncestor] = yAncestor;
            Count--;
        }
    }
}