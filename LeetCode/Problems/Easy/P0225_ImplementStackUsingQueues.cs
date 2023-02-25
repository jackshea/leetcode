using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 用队列实现栈
/// https://leetcode-cn.com/problems/implement-stack-using-queues/
public class P0225_ImplementStackUsingQueues
{
    private readonly Queue<int> _queue = new();

    /**
     * Initialize your data structure here.
     */
    public P0225_ImplementStackUsingQueues()
    {
    }

    /**
     * Push element x onto stack.
     */
    public void Push(int x)
    {
        _queue.Enqueue(x);
        var queueCount = _queue.Count;
        for (var i = 0; i < queueCount - 1; i++) _queue.Enqueue(_queue.Dequeue());
    }

    /**
     * Removes the element on top of the stack and returns that element.
     */
    public int Pop()
    {
        return _queue.Dequeue();
    }

    /**
     * Get the top element.
     */
    public int Top()
    {
        return _queue.Peek();
    }

    /**
     * Returns whether the stack is empty.
     */
    public bool Empty()
    {
        return _queue.Count == 0;
    }
}