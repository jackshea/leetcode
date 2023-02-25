using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 堆盘子
/// https://leetcode-cn.com/problems/stack-of-plates-lcci/
public class StackOfPlates
{
    private readonly int _capacity;
    private readonly List<Stack<int>> ls;
    private Stack<int> stack;

    public StackOfPlates(int cap)
    {
        _capacity = cap;
        stack = new Stack<int>(_capacity);
        ls = new List<Stack<int>> { stack };
    }

    public void Push(int val)
    {
        if (_capacity == 0) return;

        if (stack.Count == _capacity)
        {
            stack = new Stack<int>();
            ls.Add(stack);
        }

        stack.Push(val);
    }

    public int Pop()
    {
        if (stack.Count == 0 && ls.Count <= 1) return -1;

        var v = stack.Pop();

        if (stack.Count == 0 && ls.Count > 1)
        {
            ls.RemoveAt(ls.Count - 1);
            stack = ls[ls.Count - 1];
        }

        return v;
    }

    public int PopAt(int index)
    {
        if (index >= ls.Count) return -1;

        if (index == 0 && ls[0].Count == 0) return -1;

        var v = ls[index].Pop();
        if (ls.Count > 1 && ls[index].Count == 0)
        {
            ls.RemoveAt(index);
            stack = ls[ls.Count - 1];
        }

        return v;
    }
}