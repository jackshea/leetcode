using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 所有可能的路径
/// https://leetcode-cn.com/problems/all-paths-from-source-to-target/
public class P0797_AllPathsFromSourceToTarget
{
    private readonly IList<IList<int>> paths = new List<IList<int>>();
    private readonly HashSet<int> visited = new();

    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        DFS(graph, 0, new List<int>());
        return paths;
    }

    public void DFS(int[][] graph, int start, List<int> curPath)
    {
        if (visited.Contains(start)) return;
        curPath.Add(start);
        visited.Add(start);
        if (start == graph.Length - 1)
            paths.Add(new List<int>(curPath));
        else
            foreach (var g in graph[start])
                DFS(graph, g, curPath);

        visited.Remove(start);
        curPath.RemoveAt(curPath.Count - 1);
    }
}