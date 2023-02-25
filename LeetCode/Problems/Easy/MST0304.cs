using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 化栈为队
/// https://leetcode-cn.com/problems/implement-queue-using-stacks-lcci/
public class MyQueue
{
    private readonly Stack<int> inStack;
    private readonly Stack<int> outStack;

    /**
     * Initialize your data structure here.
     */
    public MyQueue()
    {
        outStack = new Stack<int>();
        inStack = new Stack<int>();
    }

    /**
     * Push element x to the back of queue.
     */
    public void Push(int x)
    {
        inStack.Push(x);
    }

    /**
     * Removes the element from in front of queue and returns that element.
     */
    public int Pop()
    {
        if (outStack.Count == 0)
            while (inStack.Count != 0)
                outStack.Push(inStack.Pop());

        return outStack.Pop();
    }

    /**
     * Get the front element.
     */
    public int Peek()
    {
        if (outStack.Count == 0)
            while (inStack.Count != 0)
                outStack.Push(inStack.Pop());

        return outStack.Peek();
    }

    /**
     * Returns whether the queue is empty.
     */
    public bool Empty()
    {
        return inStack.Count == 0 && outStack.Count == 0;
    }
}