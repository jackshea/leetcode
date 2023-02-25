using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 重新安排行程
/// https://leetcode-cn.com/problems/reconstruct-itinerary/
public class P0332_ReconstructItinerary
{
    public IList<string> FindItinerary(IList<IList<string>> tickets)
    {
        var list = new List<string>();
        var dict = new Dictionary<string, List<string>>();
        foreach (var t in tickets)
        {
            if (!dict.ContainsKey(t[0]))
                dict[t[0]] = new List<string>();
            dict[t[0]].Add(t[1]);
        }

        foreach (var s in dict.Keys)
            dict[s].Sort();
        DFS("JFK", list, dict);
        return list;
    }

    private void DFS(string start, List<string> list, Dictionary<string, List<string>> dict)
    {
        while (dict.ContainsKey(start) && dict[start].Count != 0)
        {
            var s = dict[start][0];
            dict[start].RemoveAt(0);
            DFS(s, list, dict);
        }

        list.Insert(0, start);
    }
}