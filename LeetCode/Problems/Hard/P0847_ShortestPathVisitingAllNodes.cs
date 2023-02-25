using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Hard;

/// 访问所有节点的最短路径
/// https://leetcode-cn.com/problems/shortest-path-visiting-all-nodes/
public class P0847_ShortestPathVisitingAllNodes
{
    public int ShortestPathLength(int[][] graph)
    {
        var n = graph.Length;
        var queue = new Queue<Tuple<int, int, int>>();
        var seen = new bool[n, 1 << n];
        for (var i = 0; i < n; i++)
        {
            // node,mask,dist
            queue.Enqueue(new Tuple<int, int, int>(i, 1 << i, 0));
            seen[i, 1 << i] = true;
        }

        var ans = 0;
        while (queue.Count > 0)
        {
            var top = queue.Dequeue();
            int node = top.Item1, mask = top.Item2, dist = top.Item3;
            if (mask == (1 << n) - 1)
            {
                ans = dist;
                break;
            }

            foreach (var v in graph[node])
            {
                var maskV = mask | (1 << v);
                if (!seen[v, maskV])
                {
                    queue.Enqueue(new Tuple<int, int, int>(v, maskV, dist + 1));
                    seen[v, maskV] = true;
                }
            }
        }

        return ans;
    }
}