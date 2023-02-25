using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 判断二分图
/// https://leetcode-cn.com/problems/is-graph-bipartite/
public class P0785_IsGraphBipartite
{
    public bool IsBipartite(int[][] graph)
    {
        var tags = new int[graph.Length];
        var q = new Queue<int>();
        for (var i = 0; i < graph.Length; i++)
        {
            if (tags[i] != 0) continue;

            q.Enqueue(i);
            var tag = 1;
            tags[i] = tag;
            while (q.Count > 0)
            {
                var count = q.Count;
                tag = tag % 2 + 1;
                for (var j = 0; j < count; j++)
                {
                    var top = q.Dequeue();
                    foreach (var next in graph[top])
                        if (tags[next] == 0)
                        {
                            q.Enqueue(next);
                            tags[next] = tag;
                        }
                        else if (tags[next] == tag)
                        {
                            // do nothing
                        }
                        else
                        {
                            return false;
                        }
                }
            }
        }


        return true;
    }
}