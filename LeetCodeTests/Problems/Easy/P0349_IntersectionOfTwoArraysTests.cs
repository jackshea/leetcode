using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0349_IntersectionOfTwoArraysTests
{
    [Test]
    public void IntersectionTest()
    {
        var num1 = new[] { 1, 2, 2, 1 };
        var num2 = new[] { 2, 2 };

        var intersection = new P0349_IntersectionOfTwoArrays().Intersection(num1, num2);
        var expect = new[] { 2 };

        Assert.AreEqual(expect, intersection);
    }
}