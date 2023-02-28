using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 合并相似的物品
/// https://leetcode.cn/problems/merge-similar-items/
public class P2363_MergeSimilarItems
{
    public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
    {
        var dic = new Dictionary<int, int>();
        foreach (var item in items1)
        {
            if (!dic.TryAdd(item[0], item[1]))
            {
                dic[item[0]] = item[1];
            }
        }
        foreach (var item in items2)
        {
            dic.TryGetValue(item[0], out var count);
            dic[item[0]] = count + item[1];
        }
        List<IList<int>> ans = new List<IList<int>>();
        foreach (var kvp in dic)
        {
            ans.Add(new List<int> { kvp.Key, kvp.Value });
        }
        ans.Sort((a, b) => a[0].CompareTo(b[0]));
        return ans;
    }
}