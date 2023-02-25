using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0414_ThirdMaximumNumberTests
{
    [Test]
    public void ThirdMaxTest()
    {
        var input = new[] { 3, 2, 1 };
        var expected = 1;
        Assert.AreEqual(expected, new P0414_ThirdMaximumNumber().ThirdMax(input));
    }

    [Test]
    public void ThirdMaxTest_1()
    {
        var input = new[] { 1, 2 };
        var expected = 2;
        Assert.AreEqual(expected, new P0414_ThirdMaximumNumber().ThirdMax(input));
    }

    [Test]
    public void ThirdMaxTest_2()
    {
        var input = new[] { 2, 2, 3, 1 };
        var expected = 1;
        Assert.AreEqual(expected, new P0414_ThirdMaximumNumber().ThirdMax(input));
    }

    [Test]
    public void ThirdMaxTest_3()
    {
        var input = new[] { 1, 1, 2 };
        var expected = 2;
        Assert.AreEqual(expected, new P0414_ThirdMaximumNumber().ThirdMax(input));
    }

    [Test]
    public void ThirdMaxTest_4()
    {
        var input = new[] { 1, 2, -2147483648 };
        var expected = -2147483648;
        Assert.AreEqual(expected, new P0414_ThirdMaximumNumber().ThirdMax(input));
    }
}