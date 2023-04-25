using System;

namespace LeetCode.Problems.Easy;

/// 按身高排序
/// https://leetcode.cn/problems/sort-the-people/
public class P2418_SortThePeople
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        int[] indexes = new int[names.Length];
        for (int i = 0; i < names.Length; i++)
        {
            indexes[i] = i;
        }
        Array.Sort(indexes, (a, b) => -heights[a].CompareTo(heights[b]));
        string[] ans = new string[names.Length];
        for (int i = 0; i < indexes.Length; i++)
        {
            ans[i] = names[indexes[i]];
        }

        return ans;
    }
}