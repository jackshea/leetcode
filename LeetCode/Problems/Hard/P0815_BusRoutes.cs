using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Hard
{
    /// 公交路线
    /// https://leetcode-cn.com/problems/bus-routes/
    public class P0815_BusRoutes
    {
        public int NumBusesToDestination(int[][] routes, int source, int target)
        {
            if (source == target)
            {
                return 0;
            }

            int n = routes.Length;
            bool[,] edge = new bool[n, n];
            Dictionary<int, IList<int>> rec = new Dictionary<int, IList<int>>();
            for (int i = 0; i < n; i++)
            {
                foreach (int site in routes[i])
                {
                    IList<int> list = new List<int>();
                    if (rec.ContainsKey(site))
                    {
                        list = rec[site];
                        foreach (int j in list)
                        {
                            edge[i, j] = edge[j, i] = true;
                        }
                        rec[site].Add(i);
                    }
                    else
                    {
                        list.Add(i);
                        rec.Add(site, list);
                    }
                }
            }

            int[] dis = new int[n];
            Array.Fill(dis, -1);
            Queue<int> que = new Queue<int>();
            if (rec.ContainsKey(source))
            {
                foreach (int bus in rec[source])
                {
                    dis[bus] = 1;
                    que.Enqueue(bus);
                }
            }
            while (que.Count > 0)
            {
                int x = que.Dequeue();
                for (int y = 0; y < n; y++)
                {
                    if (edge[x, y] && dis[y] == -1)
                    {
                        dis[y] = dis[x] + 1;
                        que.Enqueue(y);
                    }
                }
            }

            int ret = int.MaxValue;
            if (rec.ContainsKey(target))
            {
                foreach (int bus in rec[target])
                {
                    if (dis[bus] != -1)
                    {
                        ret = Math.Min(ret, dis[bus]);
                    }
                }
            }
            return ret == int.MaxValue ? -1 : ret;
        }

        /// 按车站BFS(超时)
        public int NumBusesToDestination_1(int[][] routes, int source, int target)
        {
            if (source == target)
            {
                return 0;
            }
            Dictionary<int, List<int>> point2Line = new Dictionary<int, List<int>>();
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

            Queue<int> q = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();
            q.Enqueue(source);
            visited.Add(source);
            int step = 0;
            while (q.Count > 0)
            {
                step++;
                int qCount = q.Count;
                for (int i = 0; i < qCount; i++)
                {
                    var top = q.Dequeue();
                    if (!point2Line.TryGetValue(top, out var line))
                    {
                        continue;
                    }

                    foreach (var r in line)
                    {
                        foreach (var p in routes[r])
                        {
                            if (p == target)
                            {
                                return step;
                            }

                            if (visited.Contains(p))
                            {
                                continue;
                            }

                            visited.Add(p);
                            q.Enqueue(p);
                        }
                    }
                }
            }

            return -1;
        }
    }
}