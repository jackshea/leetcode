﻿using System;
using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 最小栈
/// https://leetcode-cn.com/problems/min-stack/description/
public class MinStack
{
    private readonly LinkedList<StackNode> stack;

    public MinStack()
    {
        stack = new LinkedList<StackNode>();
    }

    public void Push(int x)
    {
        if (stack.Count == 0)
        {
            stack.AddLast(new StackNode { Value = x, MinValue = x });
        }
        else
        {
            var min = Math.Min(GetMin(), x);
            stack.AddLast(new StackNode { Value = x, MinValue = min });
        }
    }

    public void Pop()
    {
        stack.RemoveLast();
    }

    public int Top()
    {
        return stack.Last.Value.Value;
    }

    public int GetMin()
    {
        return stack.Last.Value.MinValue;
    }
}

public struct StackNode
{
    public int Value;
    public int MinValue;
}