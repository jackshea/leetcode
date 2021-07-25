using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 从相邻元素对还原数组
    /// https://leetcode-cn.com/problems/restore-the-array-from-adjacent-pairs/
    public class P1743_RestoreTheArrayFromAdjacentPairs
    {
        public int[] RestoreArray(int[][] adjacentPairs)
        {
            Dictionary<int, List<int>> edges = new Dictionary<int, List<int>>();
            foreach (var adjacentPair in adjacentPairs)
            {
                AddAdjacentPairs(edges, adjacentPair[0], adjacentPair[1]);
            }

            int cur = int.MinValue;
            foreach (var edge in edges)
            {
                if (edge.Value.Count == 1)
                {
                    cur = edge.Key;
                    break;
                }
            }

            var n = adjacentPairs.Length + 1;
            int[] ans = new int[n];
            ans[0] = cur;
            cur = edges[cur][0];
            ans[1] = cur;
            for (int i = 2; i < n; i++)
            {
                var next = edges[cur];
                cur = next[0] != ans[i - 2] ? next[0] : next[1];
                ans[i] = cur;
            }

            return ans;
        }

        private void AddAdjacentPairs(Dictionary<int, List<int>> edges, int a, int b)
        {
            if (!edges.TryGetValue(a, out var list))
            {
                list = new List<int>();
                edges.Add(a, list);
            }
            list.Add(b);
            if (!edges.TryGetValue(b, out var listb))
            {
                listb = new List<int>();
                edges.Add(b, listb);
            }
            listb.Add(a);
        }
    }
}