using System.Collections.Generic;

namespace LeetCode.Problems.Hard;

/// 项目管理
/// https://leetcode-cn.com/problems/sort-items-by-groups-respecting-dependencies/
public class P1203_SortItemsByGroupsRespectingDependencies
{
    // todo
    public int[] SortItems(int n, int m, int[] group, IList<IList<int>> beforeItems)
    {
        var groupItem = new List<List<int>>();
        for (var i = 0; i < n + m; ++i) groupItem.Add(new List<int>());

        // 组间和组内依赖图
        var groupGraph = new List<List<int>>();
        for (var i = 0; i < n + m; ++i) groupGraph.Add(new List<int>());
        var itemGraph = new List<List<int>>();
        for (var i = 0; i < n; ++i) itemGraph.Add(new List<int>());

        // 组间和组内入度数组
        var groupDegree = new int[n + m];
        var itemDegree = new int[n];

        var id = new List<int>();
        for (var i = 0; i < n + m; ++i) id.Add(i);

        var leftId = m;
        // 给未分配的 item 分配一个 groupId
        for (var i = 0; i < n; ++i)
        {
            if (group[i] == -1)
            {
                group[i] = leftId;
                leftId += 1;
            }

            groupItem[group[i]].Add(i);
        }

        // 依赖关系建图
        for (var i = 0; i < n; ++i)
        {
            var curGroupId = group[i];
            foreach (var item in beforeItems[i])
            {
                var beforeGroupId = group[item];
                if (beforeGroupId == curGroupId)
                {
                    itemDegree[i] += 1;
                    itemGraph[item].Add(i);
                }
                else
                {
                    groupDegree[curGroupId] += 1;
                    groupGraph[beforeGroupId].Add(curGroupId);
                }
            }
        }

        // 组间拓扑关系排序
        var groupTopSort = TopSort(groupDegree, groupGraph, id);
        if (groupTopSort.Count == 0) return new int[0];
        var ans = new int[n];
        var index = 0;

        // 组内拓扑关系排序
        foreach (var curGroupId in groupTopSort)
        {
            var size = groupItem[curGroupId].Count;
            if (size == 0) continue;
            var res = TopSort(itemDegree, itemGraph, groupItem[curGroupId]);
            if (res.Count == 0) return new int[0];
            foreach (var item in res) ans[index++] = item;
        }

        return ans;
    }

    private List<int> TopSort(int[] deg, List<List<int>> graph, List<int> items)
    {
        var queue = new Queue<int>();
        foreach (var item in items)
            if (deg[item] == 0)
                queue.Enqueue(item);
        var res = new List<int>();
        while (queue.Count > 0)
        {
            var u = queue.Dequeue();
            res.Add(u);
            foreach (var v in graph[u])
                if (--deg[v] == 0)
                    queue.Enqueue(v);
        }

        return res.Count == items.Count ? res : new List<int>();
    }
}