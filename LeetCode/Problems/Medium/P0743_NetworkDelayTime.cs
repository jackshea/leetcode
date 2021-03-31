using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium
{
    /// 网络延迟时间
    /// https://leetcode-cn.com/problems/network-delay-time/
    public class P0743_NetworkDelayTime
    {
        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            List<int[]>[] graph = new List<int[]>[n + 1];
            foreach (var time in times)
            {
                int from = time[0], to = time[1], weight = time[2];
                if (graph[from] == null)
                {
                    graph[from] = new List<int[]>();
                }
                graph[from].Add(new[] { to, weight });
            }

            int[] dist = new int[n + 1];
            Array.Fill(dist, int.MaxValue);
            dist[k] = 0;
            bool[] visited = new bool[n + 1];
            while (true)
            {
                int candNode = -1;
                int candDist = int.MaxValue;
                for (int i = 1; i <= n; i++)
                {
                    if (!visited[i] && dist[i] < candDist)
                    {
                        candDist = dist[i];
                        candNode = i;
                    }
                }

                if (candNode < 0)
                {
                    break;
                }

                visited[candNode] = true;
                if (graph[candNode] != null)
                {
                    foreach (var e in graph[candNode])
                    {
                        dist[e[0]] = Math.Min(dist[e[0]], dist[candNode] + e[1]);
                    }
                }
            }

            int ans = 0;
            for (var i = 1; i <= n; i++)
            {
                var d = dist[i];
                if (d == int.MaxValue)
                {
                    return -1;
                }

                ans = Math.Max(ans, d);
            }

            return ans;
        }
    }
}