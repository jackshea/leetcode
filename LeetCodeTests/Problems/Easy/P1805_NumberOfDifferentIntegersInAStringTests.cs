using NUnit.Framework;

namespace LeetCode.Problems.Easy.Tests;

[TestFixture]
public class P1805_NumberOfDifferentIntegersInAStringTests
{
    [Test]
    public void NumDifferentIntegersTest()
    {
        var test = new P1805_NumberOfDifferentIntegersInAString();
        Assert.AreEqual(1, test.NumDifferentIntegers("a1b01c001"));
    }

    [Test]
    public void NumDifferentIntegersTest2()
    {
        var test = new P1805_NumberOfDifferentIntegersInAString();
        Assert.AreEqual(1, test.NumDifferentIntegers("0a0"));
    }
}