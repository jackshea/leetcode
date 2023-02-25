using System.Collections.Generic;

namespace LeetCode.Problems.Easy;

/// 剑指 Offer 09. 用两个栈实现队列
/// https://leetcode-cn.com/problems/yong-liang-ge-zhan-shi-xian-dui-lie-lcof/
public class CQueue
{
    private readonly Stack<int> head;
    private readonly Stack<int> tail;

    public CQueue()
    {
        head = new Stack<int>();
        tail = new Stack<int>();
    }

    public void AppendTail(int value)
    {
        tail.Push(value);
    }

    public int DeleteHead()
    {
        if (head.Count != 0) return head.Pop();

        while (tail.Count > 0) head.Push(tail.Pop());

        return head.Count != 0 ? head.Pop() : -1;
    }
}