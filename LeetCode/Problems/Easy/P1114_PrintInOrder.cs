using System;
using System.Threading;

namespace LeetCode.Problems.Easy;

/// 按序打印
/// https://leetcode-cn.com/problems/print-in-order/
public class Foo
{
    private readonly AutoResetEvent second = new(false);
    private readonly AutoResetEvent third = new(false);

    public void First(Action printFirst)
    {
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        second.Set();
    }

    public void Second(Action printSecond)
    {
        second.WaitOne();
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        third.Set();
    }

    public void Third(Action printThird)
    {
        third.WaitOne();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
    }
}