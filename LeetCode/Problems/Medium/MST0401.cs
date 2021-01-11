using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 节点间通路
    /// https://leetcode-cn.com/problems/route-between-nodes-lcci/
    public class MST0401
    {
        private Queue<int>[] g;

        public bool FindWhetherExistsPath(int n, int[][] graph, int start, int target)
        {
            g = new Queue<int>[n];
            for (int i = 0; i < n; i++)
            {
                g[i] = new Queue<int>();
            }

            for (int i = 0; i < graph.Length; i++)
            {
                g[graph[i][0]].Enqueue(graph[i][1]);
            }

            return DFS(start, target);
        }

        private bool DFS(int start, int target)
        {
            if (start == target)
            {
                return true;
            }

            while (g[start].Count != 0)
            {
                if (DFS(g[start].Dequeue(), target))
                {
                    return true;
                }
            }

            return false;
        }
    }
}