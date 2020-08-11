using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 最小高度树
    /// https://leetcode-cn.com/problems/minimum-height-trees/
    public class P0310_MinimumHeightTrees
    {
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            List<int> ans = new List<int>();
            if (n == 1)
            {
                ans.Add(0);
                return ans;
            }
            List<int>[] adj = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                adj[i] = new List<int>();
            }

            int[] degree = new int[n];
            foreach (var edge in edges)
            {
                adj[edge[0]].Add(edge[1]);
                adj[edge[1]].Add(edge[0]);
                degree[edge[0]]++;
                degree[edge[1]]++;
            }

            Queue<int> q = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                if (degree[i] == 1)
                {
                    q.Enqueue(i);
                }
            }

            while (q.Count != 0)
            {
                ans = new List<int>();
                int count = q.Count;
                for (int i = 0; i < count; i++)
                {
                    int top = q.Dequeue();
                    ans.Add(top);
                    foreach (var near in adj[top])
                    {
                        degree[near]--;
                        if (degree[near] == 1)
                        {
                            q.Enqueue(near);
                        }
                    }
                }
            }

            return ans;
        }
    }
}