using LeetCode.Problems.Easy;
using NUnit.Framework;

namespace LeetCodeTests.Problems.Easy;

[TestFixture]
public class P0066_PlusOneTests
{
    [Test]
    public void PlusOneTest_1()
    {
        var test = new P0066_PlusOne();
        var input = new[] { 1, 2, 3 };

        var output = test.PlusOne(input);

        Assert.AreEqual(new[] { 1, 2, 4 }, output);
    }

    [Test]
    public void PlusOneTest_2()
    {
        var test = new P0066_PlusOne();
        var input = new[] { 0 };

        var output = test.PlusOne(input);

        Assert.AreEqual(new[] { 1 }, output);
    }

    [Test]
    public void PlusOneTest_3()
    {
        var test = new P0066_PlusOne();
        var input = new[] { 1, 0, 9 };

        var output = test.PlusOne(input);

        Assert.AreEqual(new[] { 1, 1, 0 }, output);
    }

    [Test]
    public void PlusOneTest_4()
    {
        var test = new P0066_PlusOne();
        var input = new[] { 9, 9, 9 };

        var output = test.PlusOne(input);

        Assert.AreEqual(new[] { 1, 0, 0, 0 }, output);
    }
}