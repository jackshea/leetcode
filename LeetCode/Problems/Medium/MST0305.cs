﻿using System.Collections.Generic;

namespace LeetCode.Problems.Medium;

/// 栈排序
/// https://leetcode-cn.com/problems/sort-of-stacks-lcci/
public class SortedStack
{
    private readonly Stack<int> main = new();
    private readonly Stack<int> minor = new();

    public void Push(int val)
    {
        while (!IsEmpty() && main.Peek() < val) minor.Push(main.Pop());
        main.Push(val);
        while (minor.Count > 0) main.Push(minor.Pop());
    }

    public void Pop()
    {
        if (!IsEmpty()) main.Pop();
    }

    public int Peek()
    {
        if (!IsEmpty()) return main.Peek();

        return -1;
    }

    public bool IsEmpty()
    {
        return main.Count == 0;
    }
}