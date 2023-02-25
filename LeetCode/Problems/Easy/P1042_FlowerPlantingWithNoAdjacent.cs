using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 不邻接植花
/// https://leetcode-cn.com/problems/flower-planting-with-no-adjacent/
public class P1042_FlowerPlantingWithNoAdjacent
{
    public int[] GardenNoAdj(int N, int[][] paths)
    {
        var adj = new List<int>[N + 1];
        for (var i = 0; i < adj.Length; i++) adj[i] = new List<int>();
        foreach (var path in paths)
        {
            adj[path[0]].Add(path[1]);
            adj[path[1]].Add(path[0]);
        }

        var ans = new int[N + 1];
        for (var i = 1; i <= N; i++)
        {
            var used = new bool[5];
            foreach (var a in adj[i]) used[ans[a]] = true;

            for (var j = 1; j <= 4; j++)
                if (!used[j])
                {
                    ans[i] = j;
                    break;
                }
        }

        var trueAns = new int[N];
        Array.Copy(ans, 1, trueAns, 0, N);
        return trueAns;
    }
}