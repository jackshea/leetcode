using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 最大网络秩
/// https://leetcode-cn.com/contest/weekly-contest-210/problems/maximal-network-rank/
public class P1615_MaximalNetworkRank
{
    public int MaximalNetworkRank(int n, int[][] roads)
    {
        var ranks = new int[n];
        var adj = new HashSet<int>[n];
        for (var i = 0; i < n; i++) adj[i] = new HashSet<int>();
        foreach (var road in roads)
        {
            ranks[road[0]]++;
            ranks[road[1]]++;
            adj[road[0]].Add(road[1]);
            adj[road[1]].Add(road[0]);
        }

        var ans = 0;
        for (var i = 0; i < n; i++)
        for (var j = i + 1; j < n; j++)
        {
            var rankSum = ranks[i] + ranks[j];
            if (rankSum > ans)
            {
                if (adj[i].Contains(j)) rankSum--;

                ans = Math.Max(ans, rankSum);
            }
        }

        return ans;
    }
}