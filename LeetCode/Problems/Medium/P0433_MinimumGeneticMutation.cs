using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 最小基因变化
/// https://leetcode-cn.com/problems/minimum-genetic-mutation/
public class P0433_MinimumGeneticMutation
{
    public int MinMutation(string start, string end, string[] bank)
    {
        var distance = 0;
        var q = new Queue<string>();
        q.Enqueue(start);
        var visited = new HashSet<string>();
        visited.Add(start);
        while (q.Count != 0)
        {
            var cnt = q.Count;
            for (var i = 0; i < cnt; i++)
            {
                var top = q.Dequeue();
                if (top == end) return distance;
                foreach (var gene in bank)
                {
                    if (visited.Contains(gene)) continue;

                    if (Different(top, gene) == 1)
                    {
                        q.Enqueue(gene);
                        visited.Add(gene);
                    }
                }
            }

            distance++;
        }

        return -1;
    }

    private int Different(string a, string b)
    {
        var ans = 0;
        for (var i = 0; i < a.Length; i++)
            if (a[i] != b[i])
                ans++;

        return ans;
    }
}