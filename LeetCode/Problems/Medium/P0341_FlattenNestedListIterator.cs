using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 扁平化嵌套列表迭代器
/// https://leetcode-cn.com/problems/flatten-nested-list-iterator/
public class NestedIterator
{
    private readonly List<int> nums = new();
    private int idx;

    public NestedIterator(IList<NestedInteger> nestedList)
    {
        foreach (var nestedInteger in nestedList) DFS(nestedInteger);
    }

    private void DFS(NestedInteger nestedInteger)
    {
        if (nestedInteger.IsInteger())
            nums.Add(nestedInteger.GetInteger());
        else
            foreach (var item in nestedInteger.GetList())
                DFS(item);
    }

    public bool HasNext()
    {
        return idx < nums.Count;
    }

    public int Next()
    {
        return nums[idx++];
    }
}

public interface NestedInteger
{
    // @return true if this NestedInteger holds a single integer, rather than a nested list.
    bool IsInteger();

    // @return the single integer that this NestedInteger holds, if it holds a single integer
    // Return null if this NestedInteger holds a nested list
    int GetInteger();

    // @return the nested list that this NestedInteger holds, if it holds a nested list
    // Return null if this NestedInteger holds a single integer
    IList<NestedInteger> GetList();
}