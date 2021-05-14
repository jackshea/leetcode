using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 找到最终的安全状态
    /// https://leetcode-cn.com/problems/find-eventual-safe-states/
    public class P0802_FindEventualSafeStates
    {
        public IList<int> EventualSafeNodes(int[][] graph)
        {
            // 0:白 1：灰 2：黑
            int[] color = new int[graph.Length];
            List<int> ans = new List<int>();
            for (int i = 0; i < graph.Length; i++)
            {
                if (DFS(i, color, graph))
                {
                    ans.Add(i);
                }
            }

            return ans;
        }

        private bool DFS(int node, int[] color, int[][] graph)
        {
            if (color[node] == 1)
            {
                return false;
            }

            if (color[node] == 2)
            {
                return true;
            }

            color[node] = 1;
            foreach (var near in graph[node])
            {
                if (color[near] == 2)
                {
                    continue;
                }

                if (color[near] == 1 || !DFS(near, color, graph))
                {
                    return false;
                }
            }

            color[node] = 2;
            return true;
        }
    }
}