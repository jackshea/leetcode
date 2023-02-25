using NUnit.Framework;

namespace LeetCode.Problems.Medium.Tests;

[TestFixture]
public class P0215_KthLargestElementInAnArrayTests
{
    [Test]
    public void FindKthLargestTest()
    {
        int[] input = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
        var test = new P0215_KthLargestElementInAnArray();
        Assert.AreEqual(4, test.FindKthLargest(input, 4));
    }
}