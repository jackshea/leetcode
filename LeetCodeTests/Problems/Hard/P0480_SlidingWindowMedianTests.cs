using NUnit.Framework;

namespace LeetCode.Problems.Hard.Tests;

[TestFixture]
public class P0480_SlidingWindowMedianTests
{
    [Test]
    public void MedianSlidingWindowTest()
    {
        var test = new P0480_SlidingWindowMedian();
        var input = new[] { 1, 3, -1, -3, 5, 3, 6, 7 };
        var ans = new[] { 1.00000, -1.00000, -1.00000, 3.00000, 5.00000, 6.00000 };
        CollectionAssert.AreEqual(ans, test.MedianSlidingWindow(input, 3));
    }
}