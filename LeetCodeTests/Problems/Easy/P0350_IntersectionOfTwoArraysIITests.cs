using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0350_IntersectionOfTwoArraysIITests
{
    [Test]
    public void IntersectTest()
    {
        var num1 = new[] { 1, 2, 2, 1 };
        var num2 = new[] { 2, 2 };

        var intersection = new P0350_IntersectionOfTwoArraysII().Intersect(num1, num2);
        var expect = new[] { 2, 2 };

        Assert.AreEqual(expect, intersection);
    }

    [Test]
    public void IntersectTest_2()
    {
        var num1 = new[] { 4, 9, 5 };
        var num2 = new[] { 9, 4, 9, 8, 4 };

        var intersection = new P0350_IntersectionOfTwoArraysII().Intersect(num1, num2);
        var expect = new[] { 4, 9 };

        Assert.AreEqual(expect, intersection);
    }
}