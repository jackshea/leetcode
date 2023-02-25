using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCode.Common.Tests;

[TestFixture]
public class PriorityQueueTests
{
    [Test]
    public void PriorityQueueTest()
    {
        var pq = new PriorityQueue<int>();
        int[] input = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
        foreach (var i in input) pq.Push(i);

        var ans = input;
        for (var i = 0; i < ans.Length; i++) ans[i] = pq.Pop();

        CollectionAssert.AreEqual(new[] { 1, 1, 2, 2, 3, 3, 4, 4, 5 }, ans);
    }

    [Test]
    public void PriorityQueueTest1()
    {
        var pq = new PriorityQueue<int>(9, Comparer<int>.Create((a, b) => -a.CompareTo(b)));
        int[] input = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
        foreach (var i in input) pq.Push(i);

        var ans = input;
        for (var i = 0; i < ans.Length; i++) ans[i] = pq.Pop();

        CollectionAssert.AreEqual(new[] { 5, 4, 4, 3, 3, 2, 2, 1, 1 }, ans);
    }
}