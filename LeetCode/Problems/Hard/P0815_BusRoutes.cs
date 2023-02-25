using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Hard;

/// 公交路线
/// https://leetcode-cn.com/problems/bus-routes/
public class P0815_BusRoutes
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        if (source == target) return 0;

        var n = routes.Length;
        var edge = new bool[n, n];
        var rec = new Dictionary<int, IList<int>>();
        for (var i = 0; i < n; i++)
            foreach (var site in routes[i])
            {
                IList<int> list = new List<int>();
                if (rec.ContainsKey(site))
                {
                    list = rec[site];
                    foreach (var j in list) edge[i, j] = edge[j, i] = true;
                    rec[site].Add(i);
                }
                else
                {
                    list.Add(i);
                    rec.Add(site, list);
                }
            }

        var dis = new int[n];
        Array.Fill(dis, -1);
        var que = new Queue<int>();
        if (rec.ContainsKey(source))
            foreach (var bus in rec[source])
            {
                dis[bus] = 1;
                que.Enqueue(bus);
            }

        while (que.Count > 0)
        {
            var x = que.Dequeue();
            for (var y = 0; y < n; y++)
                if (edge[x, y] && dis[y] == -1)
                {
                    dis[y] = dis[x] + 1;
                    que.Enqueue(y);
                }
        }

        var ret = int.MaxValue;
        if (rec.ContainsKey(target))
            foreach (var bus in rec[target])
                if (dis[bus] != -1)
                    ret = Math.Min(ret, dis[bus]);
        return ret == int.MaxValue ? -1 : ret;
    }

    /// 按车站BFS(超时)
    public int NumBusesToDestination_1(int[][] routes, int source, int target)
    {
        if (source == target) return 0;
        var point2Line = new Dictionary<int, List<int>>();
        for (var i = 0; i < routes.Length; i++)
        {
            var route = routes[i];
            foreach (var p in route)
            {
                if (!point2Line.TryGetValue(p, out var line))
                {
                    line = new List<int>();
                    point2Line.Add(p, line);
                }

                line.Add(i);
            }
        }

        var q = new Queue<int>();
        var visited = new HashSet<int>();
        q.Enqueue(source);
        visited.Add(source);
        var step = 0;
        while (q.Count > 0)
        {
            step++;
            var qCount = q.Count;
            for (var i = 0; i < qCount; i++)
            {
                var top = q.Dequeue();
                if (!point2Line.TryGetValue(top, out var line)) continue;

                foreach (var r in line)
                foreach (var p in routes[r])
                {
                    if (p == target) return step;

                    if (visited.Contains(p)) continue;

                    visited.Add(p);
                    q.Enqueue(p);
                }
            }
        }

        return -1;
    }
}